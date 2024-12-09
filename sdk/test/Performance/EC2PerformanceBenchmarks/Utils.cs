/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3;
using Amazon.S3.Model;
using ServiceClientGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AWSSDK.Benchmarks
{
    public static class Utils
    {
        public static ServiceModel LoadServiceModel(string service)
        {
            string repoRoot = Directory.GetCurrentDirectory();
            do
            {
                if (Directory.Exists(Path.Combine(repoRoot, "generator")))
                {
                    break;
                }

                var directoryInfo = Directory.GetParent(repoRoot);
                repoRoot = directoryInfo != null ? directoryInfo.FullName : null;
            } while (repoRoot != null);

            string serviceModelDirectory = Path.Combine(repoRoot, "generator", "ServiceModels", service);

            string modelPath = GetLatestModelPath(serviceModelDirectory);
            string customizationsPath = Path.Combine(serviceModelDirectory, service + ".customizations.json");

            using (var streamReader = new StreamReader(modelPath))
            {
                StreamReader customizationsReader = null;
                if (File.Exists(customizationsPath))
                {
                    using (customizationsReader = new StreamReader(customizationsPath))
                    {
                        return new ServiceModel(streamReader, customizationsReader);
                    }
                }
                return new ServiceModel(streamReader, null);
            }
        }

        private static string GetLatestModelPath(string serviceDirectory)
        {
            string latestModelPath = "";
            foreach (string modelName in Directory.GetFiles(serviceDirectory, "*.normal.json", SearchOption.TopDirectoryOnly))
            {
                if (string.Compare(latestModelPath, modelName) < 0)
                {
                    latestModelPath = modelName;
                }
            }

            if (string.IsNullOrEmpty(latestModelPath))
            {
                throw new FileNotFoundException("Failed to find a model file in " + serviceDirectory);
            }

            return latestModelPath;
        }

        public static Stream CreateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }


        public static Stream GetResourceStream(string resourceName)
        {
            Assembly assembly = typeof(Utils).Assembly;
            var resource = FindResourceName(assembly, resourceName);
            if (resource == null)
            {
                assembly = Assembly.GetCallingAssembly();
                resource = FindResourceName(assembly, resourceName);
            }

            Stream stream = assembly.GetManifestResourceStream(resource);
            return stream;
        }
        public static string GetResourceText(string resourceName)
        {
            using (StreamReader reader = new StreamReader(GetResourceStream(resourceName)))
            {
                return reader.ReadToEnd();
            }
        }
        public static string FindResourceName(Assembly assembly, string partialName)
        {
            var resources = FindResourceName(assembly, s => s.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0);
            if (resources.Any())
                return resources.Single();
            return null;
        }
        public static IEnumerable<string> FindResourceName(Assembly assembly, Predicate<string> match)
        {
            var allResources = assembly.GetManifestResourceNames();
            foreach (var resource in allResources)
            {
                if (match(resource))
                    yield return resource;
            }
        }
        public static void DisposeClient(IDisposable client)
        {
            if (client != null)
            {
                client.Dispose();
            }
        }
        public static string GenerateName(string name)
        {
            return name + new Random().Next();
        }
        public static MemoryStream GenerateStreamFromFile(string filePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            MemoryStream memoryStream = new MemoryStream(fileBytes);
            memoryStream.Position = 0;  
            return memoryStream;
        }
        public static string CreateMessage(long messageSizeInBytes)
        {
            var messageBody = CreateStringOfSize(messageSizeInBytes);
            return messageBody;
        }
        private static string CreateStringOfSize(long sizeInBytes)
        {
            //2 bytes are needed for each characterse, since .net strings are UTF-16
            int numCharacters = (int)sizeInBytes / 2;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < numCharacters; i++)
            {
                stringBuilder.Append('A');
            }
            return stringBuilder.ToString();
        }
        public static async Task<string> CreateBucket(IAmazonS3 s3Client)
        {
            string bucketName = Constants.SdkTestPrefix + DateTime.UtcNow.Ticks;
            await s3Client.PutBucketAsync(new PutBucketRequest { BucketName = bucketName });
            return bucketName;
        }
        public static void GenerateFile(string path, long size)
        {
            string contents = GenerateTestContents(size);
            WriteFile(path, contents);
        }
        public static string GenerateTestContents(long size)
        {
            StringBuilder sb = new StringBuilder();
            for (long i = 0; i < size; i++)
            {
                char c = (char)('a' + (i % 26));
                sb.Append(c);
            }
            string contents = sb.ToString();
            return contents;
        }

        public static void WriteFile(string path, string contents)
        {
            string fullPath = Path.GetFullPath(path);
            new DirectoryInfo(Path.GetDirectoryName(fullPath)).Create();
            File.WriteAllText(fullPath, contents);
        }
    }
}
