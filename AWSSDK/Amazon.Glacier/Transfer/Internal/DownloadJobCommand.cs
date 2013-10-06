/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

using Amazon.Glacier.Model;
using Amazon.Util;

namespace Amazon.Glacier.Transfer.Internal
{
    internal class DownloadJobCommand
    {
        const int PART_STREAM_HASH_SIZE = 1024 * 1024;

        ArchiveTransferManager manager;
        string vaultName;
        string jobId;
        string filePath;
        DownloadOptions options;

        internal DownloadJobCommand(ArchiveTransferManager manager, string vaultName, string jobId, string filePath, DownloadOptions options)
        {
            this.manager = manager;
            this.vaultName = vaultName;
            this.jobId = jobId;
            this.filePath = filePath;
            this.options = options;

            if (this.options == null)
                this.options = new DownloadOptions();
        }

        internal void Execute()
        {
            long contentLength = -1;
            string glacierProvidedCheckSum = null;
            string rangeValue = null;
            Stream input = null;
            Stream output = null;
            try
            {
                // Make sure the directory exists to write too.
                FileInfo fi = new FileInfo(filePath);
                Directory.CreateDirectory(fi.DirectoryName);
                FileMode fileMode = FileMode.Create;

                int retryAttempts = 0;
                byte[] buffer = new byte[1024 * 1024 * 5];
                long transferredBytes = 0;

                MemoryStream partStream = new MemoryStream(new byte[PART_STREAM_HASH_SIZE]);
                LinkedList<string> hashes = new LinkedList<string>();

                while (true)
                {
                    try
                    {
                        output = File.Open(filePath, fileMode, FileAccess.Write, FileShare.None);
                        try
                        {
                            GetJobOutputRequest getJobOutputRequest = new GetJobOutputRequest
                            {
                                AccountId = this.options.AccountId,
                                VaultName = this.vaultName,
                                JobId = jobId,
                                Range = rangeValue
                            };
                            getJobOutputRequest.BeforeRequestEvent += new UserAgentPostFix("DownloadArchive").UserAgentRequestEventHandlerSync;
                            GetJobOutputResponse jobOutputResponse = this.manager.GlacierClient.GetJobOutput(getJobOutputRequest);
                            if (contentLength < 0)
                            {
                                contentLength = jobOutputResponse.ContentLength;
                                glacierProvidedCheckSum = jobOutputResponse.GetJobOutputResult.Checksum;
                            }

                            input = new BufferedStream(jobOutputResponse.GetJobOutputResult.Body);

                            long totalBytesFromGetJobOutput = jobOutputResponse.ContentLength;
                            long bytesReadFromGetJobOutput = 0;
                            int bytesRead = 0;
                            do
                            {
                                bytesRead = input.Read(buffer, 0, buffer.Length);
                                if (bytesRead > 0)
                                {
                                    bytesReadFromGetJobOutput += bytesRead;

                                    output.Write(buffer, 0, bytesRead);
                                    transferredBytes += bytesRead;

                                    int offset = 0;

                                    if (partStream.Position + bytesRead > PART_STREAM_HASH_SIZE)
                                    {
                                        var length = PART_STREAM_HASH_SIZE - (int)partStream.Position;
                                        partStream.Write(buffer, 0, length);
                                        offset = length;
                                    }
                                    else
                                    {
                                        partStream.Write(buffer, 0, bytesRead);
                                        offset = bytesRead;
                                    }

                                    if (partStream.Position == PART_STREAM_HASH_SIZE)
                                    {
                                        partStream.Position = 0;
                                        hashes.AddLast(TreeHashGenerator.CalculateTreeHash(partStream));
                                    }

                                    if (offset != bytesRead)
                                    {
                                        partStream.Write(buffer, offset, bytesRead - offset);
                                    }

                                    // Make callback on progress
                                    AWSSDKUtils.InvokeInBackground(
                                        this.options.StreamTransferProgress,
                                        new Runtime.StreamTransferProgressArgs(bytesRead, transferredBytes, contentLength),
                                        this.manager);
                                }

                                if (retryAttempts > 0)
                                    retryAttempts = 0; // Reset retry attempts back to 0 since we able to successfully write more data to disk.

                            } while (bytesReadFromGetJobOutput < totalBytesFromGetJobOutput);

                            // Compute hash of the last remaining bytes
                            if (partStream.Position != 0)
                            {
                                partStream.SetLength(partStream.Position);
                                partStream.Position = 0;
                                hashes.AddLast(TreeHashGenerator.CalculateTreeHash(partStream));
                            }

                            break;
                        }
                        finally
                        {
                            output.Close();
                            output = null;

                            try { if (input != null) input.Close(); }
                            catch (Exception) { }
                        }
                    }
                    catch (Exception e)
                    {
                        if (e is AmazonGlacierException && ((AmazonGlacierException)e).StatusCode == HttpStatusCode.NotFound)
                        {
                            throw;
                        }

                        fileMode = FileMode.Append;
                        rangeValue = string.Format("bytes={0}-", new FileInfo(filePath).Length);
                        retryAttempts++;

                        if (retryAttempts <= DownloadFileCommand.MAX_OPERATION_RETRY)
                        {
                            Console.WriteLine("Error and going to retry: {0}", e.Message);
                            Console.WriteLine(e.StackTrace);

                            Thread.Sleep(60 * 1000);
                        }
                        else
                            throw;
                    }
                }

                var computedCheckSum = TreeHashGenerator.CalculateTreeHash(hashes);
                if (!string.Equals(glacierProvidedCheckSum, computedCheckSum, StringComparison.InvariantCultureIgnoreCase))
                {
                    throw new AmazonGlacierException("Checksum of the downloaded file does not match the checksum reported by Amazon Glacier.");
                }
            }
            catch (IOException e)
            {
                throw new IOException("Unable to save archive to disk", e);
            }
            finally
            {
                try { if (input != null) input.Close(); }
                catch (Exception) { }
                try { if (output != null) output.Close(); }
                catch (Exception) { }
            }
        }
    }
}
