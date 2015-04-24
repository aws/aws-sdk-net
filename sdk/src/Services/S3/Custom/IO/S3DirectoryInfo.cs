/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.Runtime.Serialization;
using System.Security.AccessControl;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.Util;
using System.Globalization;

namespace Amazon.S3.IO
{
    /// <summary>
    /// Mimics the System.IO.DirectoryInfo for a virtual directory in S3.  It exposes properties and methods for enumerating directories and files as well as 
    /// methods manipulate directories.
    /// </summary>
    /// <remarks>
    /// <note type='note'>It is important to keep in mind that S3 is not a filesystem. It is possible for S3 object keys to contain 
    /// characters which are not not legal file path characters, and so some pre-existing objects in a bucket that were created with 
    /// other software may not be compatible with this class.</note> 
    /// </remarks>
    public sealed class S3DirectoryInfo : IS3FileSystemInfo
    {
        const int EVENTUAL_CONSISTENCY_SUCCESS_IN_ROW = 10;
        const int EVENTUAL_CONSISTENCY_POLLING_PERIOD = 1000;
        const long EVENTUAL_CONSISTENCY_MAX_WAIT = 30000;

        private IAmazonS3 s3Client;
        private string bucket;
        private string key;

        internal IAmazonS3 S3Client
        {
            get
            {
                return s3Client;
            }
        }
        internal string BucketName
        {
            get
            {
                return bucket;
            }
        }
        internal string ObjectKey
        {
            get
            {
                return key;
            }
        }

        /// <summary>
        /// Initialize a new instance of the S3DirectoryInfo class for the specified S3 bucket.
        /// </summary>
        /// <param name="s3Client">S3 client which is used to access the S3 resources.</param>
        /// <param name="bucket">Name of the S3 bucket.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        public S3DirectoryInfo(IAmazonS3 s3Client, string bucket)
            : this(s3Client, bucket, null)
        {
        }

        /// <summary>
        /// Initialize a new instance of the S3DirectoryInfo class for the specified S3 bucket and S3 object key.
        /// </summary>
        /// <param name="s3Client">S3 client which is used to access the S3 resources.</param>
        /// <param name="bucket">Name of the S3 bucket.</param>
        /// <param name="key">The S3 object key.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        public S3DirectoryInfo(IAmazonS3 s3Client, string bucket, string key)
        {
            if (s3Client == null)
            {
                throw new ArgumentNullException("s3Client");
            }
            if (String.IsNullOrEmpty(bucket) && !String.IsNullOrEmpty(key))
            {
                throw new ArgumentException("key cannot be specified if bucket isn't");
            }

            this.s3Client = s3Client;
            this.bucket = bucket ?? String.Empty;
            this.key = key ?? String.Empty;

            if (!String.IsNullOrEmpty(bucket) && !String.IsNullOrEmpty(key) && !this.key.EndsWith("\\", StringComparison.Ordinal))
            {
                this.key = string.Format(CultureInfo.InvariantCulture, "{0}{1}", this.key, "\\");
            }
            if (String.Equals(this.key, "\\", StringComparison.Ordinal))
            {
                this.key = String.Empty;
            }
        }

        /// <summary>
        /// The S3DirectoryInfo for the root of the S3 bucket.
        /// </summary>
        public S3DirectoryInfo Bucket
        {
            get
            {
                return new S3DirectoryInfo(s3Client, bucket, "");
            }
        }

        /// <summary>
        /// Checks with S3 to see if the directory exists and if so returns true.
        /// 
        /// Due to Amazon S3's eventual consistency model this property can return false for newly created buckets.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public bool Exists
        {
            get
            {
                bool bucketExists;
                return ExistsWithBucketCheck(out bucketExists);
            }
        }

        internal bool ExistsWithBucketCheck(out bool bucketExists)
        {
            bucketExists = true;
            try
            {
                if (String.IsNullOrEmpty(bucket))
                {
                    return true;
                }
                else if (String.IsNullOrEmpty(key))
                {
                    var request = new GetBucketLocationRequest()
                    {
                        BucketName = bucket
                    };
                    ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);

                    try
                    {
                        s3Client.GetBucketLocation(request);
                        return true;
                    }
                    catch(AmazonS3Exception e)
                    {
                        if(string.Equals(e.ErrorCode, "NoSuchBucket"))
                        {
                            return false;
                        }
                        throw;
                    }
                }
                else
                {
                    var request = new ListObjectsRequest()
                    {
                        BucketName = this.bucket,
                        Prefix = S3Helper.EncodeKey(key),
                        MaxKeys = 1
                    };
                    ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);

                    var response = s3Client.ListObjects(request);
                    return response.S3Objects.Count > 0;
                }
            }
            catch (AmazonS3Exception e)
            {
                if (string.Equals(e.ErrorCode, "NoSuchBucket"))
                {
                    bucketExists = false;
                    return false;
                }
                else if (string.Equals(e.ErrorCode, "NotFound"))
                {
                    return false;
                }
                throw;
            }
        }

        /// <summary>
        /// Returns empty string for directories.
        /// </summary>
        string IS3FileSystemInfo.Extension
        {
            get
            {
                return String.Empty;
            }
        }

        /// <summary>
        /// The full path of the directory including bucket name.
        /// </summary>
        public string FullName
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "{0}:\\{1}", bucket, key);
            }
        }

        /// <summary>
        /// Returns the last write time of the the latest file written to the directory.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public DateTime LastWriteTime
        {
            get
            {
                DateTime ret = DateTime.MinValue;
                if (Exists)
                {
                    if (String.IsNullOrEmpty(this.bucket))
                    {
                        ret = DateTime.MinValue;
                        var listRequest = new ListBucketsRequest();
                        ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)listRequest).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);

                        foreach (S3Bucket s3Bucket in s3Client.ListBuckets(listRequest).Buckets)
                        {
                            DateTime currentBucketLastWriteTime = new S3DirectoryInfo(s3Client, s3Bucket.BucketName, String.Empty).LastWriteTime;
                            if (currentBucketLastWriteTime > ret)
                            {
                                ret = currentBucketLastWriteTime;
                            }
                        }
                    }
                    else
                    {
                        var request = new ListObjectsRequest
                        {
                            BucketName = bucket,
                            Prefix = S3Helper.EncodeKey(key)
                        };
                        ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);

                        S3Object lastWrittenObject =
                                ((IEnumerable<S3Object>)
                                    PaginatedResourceFactory.Create<S3Object, ListObjectsRequest, ListObjectsResponse>(new PaginatedResourceInfo()
                                        .WithClient(s3Client)
                                        .WithItemListPropertyPath("S3Objects")
                                        .WithMethodName("ListObjects")
                                        .WithRequest(request)
                                        .WithTokenRequestPropertyPath("Marker")
                                        .WithTokenResponsePropertyPath("NextMarker")))
                                    .OrderByDescending(s3Object => s3Object.LastModified)
                                    .FirstOrDefault();
                        if (lastWrittenObject != null)
                        {
                            ret = lastWrittenObject.LastModified;
                        }
                    }
                }

                return ret;
            }
        }

        /// <summary>
        /// UTC converted version of LastWriteTime.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public DateTime LastWriteTimeUtc
        {
            get
            {
                return LastWriteTime.ToUniversalTime();
            }
        }

        /// <summary>
        /// Returns the name of the folder.
        /// </summary>
        public string Name
        {
            get
            {
                string ret = String.Empty;
                if (!String.IsNullOrEmpty(bucket))
                {
                    if (String.IsNullOrEmpty(key))
                    {
                        ret = bucket;
                    }
                    else
                    {
                        int end = key.LastIndexOf('\\');
                        int start = key.LastIndexOf('\\', end - 1);
                        return key.Substring(start + 1, end - start - 1);
                    }
                }
                return ret;
            }
        }

        /// <summary>
        /// Return the S3DirectoryInfo of the parent directory.
        /// </summary>
        public S3DirectoryInfo Parent
        {
            get
            {
                S3DirectoryInfo ret = null;
                if (!String.IsNullOrEmpty(bucket) && !String.IsNullOrEmpty(key))
                {
                    int last = key.LastIndexOf('\\');
                    int secondlast = key.LastIndexOf('\\', last - 1);
                    if (secondlast == -1)
                    {
                        ret = Bucket;
                    }
                    else
                    {
                        var bucketName = key.Substring(0, secondlast);
                        ret = new S3DirectoryInfo(s3Client, bucket, bucketName);
                    }
                }
                if (ret == null)
                {
                    ret = Root;
                }
                return ret;
            }
        }

        /// <summary>
        /// Returns the S3DirectroyInfo for the S3 account.
        /// </summary>
        public S3DirectoryInfo Root
        {
            get
            {
                return new S3DirectoryInfo(s3Client, "", "");
            }
        }

        /// <summary>
        /// Returns the type of file system element.
        /// </summary>
        public FileSystemType Type
        {
            get
            {
                return FileSystemType.Directory;
            }
        }

        /// <summary>
        /// Creates the directory in S3.  If no object key was specified when creating the S3DirectoryInfo then the bucket will be created.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public void Create()
        {
            bool bucketExists;
            if (!ExistsWithBucketCheck(out bucketExists))
            {
                if (String.IsNullOrEmpty(key))
                {
                    var request = new PutBucketRequest
                    {
                        BucketName = bucket
                    };
                    ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);
                    s3Client.PutBucket(request);

                    WaitTillBucketS3StateIsConsistent(true);
                }
                else
                {
                    if (!bucketExists)
                    {
                        var request = new PutBucketRequest
                        {
                            BucketName = bucket
                        };
                        ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);
                        s3Client.PutBucket(request);

                        WaitTillBucketS3StateIsConsistent(true);
                    }

                    var putObjectRequest = new PutObjectRequest
                    {
                        BucketName = bucket,
                        Key = S3Helper.EncodeKey(key),
                        InputStream = new MemoryStream()
                    };
                    ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)putObjectRequest).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);

                    s3Client.PutObject(putObjectRequest);
                }
            }
        }

        /// <summary>
        /// Creates a sub directory inside the instance of S3DirectoryInfo.
        /// </summary>
        /// <param name="directory"></param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns></returns>
        public S3DirectoryInfo CreateSubdirectory(string directory)
        {
            S3DirectoryInfo ret = null;
            ret = GetDirectory(directory);
            ret.Create();
            return ret;
        }

        /// <summary>
        /// Deletes all the files in this directory as well as this directory.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <exception cref="T:Amazon.S3.Model.DeleteObjectsException"></exception>
        public void Delete()
        {
            Delete(false);
        }

        /// <summary>
        /// Deletes all the files in this directory as well as this directory.  If recursive is set to true then all sub directories will be 
        /// deleted as well.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <exception cref="T:Amazon.S3.Model.DeleteObjectsException"></exception>
        /// <param name="recursive">If true then sub directories will be deleted as well.</param>
        public void Delete(bool recursive)
        {
            if (String.IsNullOrEmpty(bucket))
            {
                throw new NotSupportedException();
            }

            if (recursive)
            {
                ListObjectsRequest listRequest = new ListObjectsRequest
                {
                    BucketName = bucket,
                    Prefix = S3Helper.EncodeKey(this.key)
                };
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)listRequest).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);

                DeleteObjectsRequest deleteRequest = new DeleteObjectsRequest
                {
                    BucketName = bucket
                };
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)deleteRequest).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);
                ListObjectsResponse listResponse = null;
                do
                {
                    listResponse = s3Client.ListObjects(listRequest);

                    // Sort to make sure the Marker for paging is set to the last lexiographical key.
                    foreach (S3Object s3o in listResponse.S3Objects.OrderBy(x => x.Key))
                    {
                        deleteRequest.AddKey(s3o.Key);
                        if (deleteRequest.Objects.Count == Util.S3Constants.MULTIPLE_OBJECT_DELETE_LIMIT)
                        {
                            s3Client.DeleteObjects(deleteRequest);
                            deleteRequest.Objects.Clear();
                        }

                        listRequest.Marker = s3o.Key;
                    }
                    
                } while (listResponse.IsTruncated);

                if (deleteRequest.Objects.Count > 0)
                {
                    s3Client.DeleteObjects(deleteRequest);
                }                
            }

            if (String.IsNullOrEmpty(key) && Exists)
            {
                var request = new DeleteBucketRequest { BucketName = bucket };
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);
                s3Client.DeleteBucket(request);
                WaitTillBucketS3StateIsConsistent(false);
            }
            else
            {
                if (!EnumerateFileSystemInfos().GetEnumerator().MoveNext() && Exists)
                {
                    var request = new DeleteObjectRequest { BucketName = bucket, Key = S3Helper.EncodeKey(key) };
                    ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);

                    s3Client.DeleteObject(request);
                    Parent.Create();
                }
            }
        }

        /// <summary>
        /// Enumerate the sub directories of this directory.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An enumerable collection of directories.</returns>
        public IEnumerable<S3DirectoryInfo> EnumerateDirectories()
        {
            return EnumerateDirectories("*",SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Enumerate the sub directories of this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all directories.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An enumerable collection of directories that matches searchPattern.</returns>
        public IEnumerable<S3DirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return EnumerateDirectories(searchPattern, SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Enumerate the sub directories of this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all directories.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is TopDirectoryOnly.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An enumerable collection of directories that matches searchPattern and searchOption.</returns>
        public IEnumerable<S3DirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            IEnumerable<S3DirectoryInfo> folders = null;
            if (String.IsNullOrEmpty(bucket))
            {
                var request = new ListBucketsRequest();
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);
                folders = s3Client.ListBuckets(request).Buckets
                    .ConvertAll(s3Bucket => new S3DirectoryInfo(s3Client,s3Bucket.BucketName,""));
            }
            else
            {
                var request = new ListObjectsRequest
                            {
                                BucketName = bucket,
                                Delimiter = "/",
                                Prefix = S3Helper.EncodeKey(key)
                            };
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);
                folders = new EnumerableConverter<string, S3DirectoryInfo>
                    ((IEnumerable<string>)(PaginatedResourceFactory.Create<string, ListObjectsRequest, ListObjectsResponse>(new PaginatedResourceInfo()
                            .WithClient(s3Client)
                            .WithMethodName("ListObjects")
                            .WithRequest(request)
                            .WithItemListPropertyPath("CommonPrefixes")
                            .WithTokenRequestPropertyPath("Marker")
                            .WithTokenResponsePropertyPath("NextMarker"))),
                        prefix => new S3DirectoryInfo(s3Client, bucket, S3Helper.DecodeKey(prefix)));
            }

            //handle if recursion is set
            if (searchOption == SearchOption.AllDirectories)
            {
                IEnumerable<S3DirectoryInfo> foldersToAdd = new List<S3DirectoryInfo>();
                foreach (S3DirectoryInfo dir in folders)
                {
                    foldersToAdd = foldersToAdd.Concat(dir.EnumerateDirectories(searchPattern, searchOption));
                }
                folders = folders.Concat(foldersToAdd);
            }
            
            //filter based on search pattern
            var regEx = WildcardToRegex(searchPattern);
            folders = folders.Where(s3dirInfo => Regex.IsMatch(s3dirInfo.Name, regEx, RegexOptions.IgnoreCase));
            return folders;
        }

        /// <summary>
        /// Enumerate the files of this directory.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An enumerable collection of files.</returns>
        public IEnumerable<S3FileInfo> EnumerateFiles()
        {
            return EnumerateFiles("*", SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Enumerate the sub directories of this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An enumerable collection of files that matches searchPattern.</returns>
        public IEnumerable<S3FileInfo> EnumerateFiles(string searchPattern)
        {
            return EnumerateFiles(searchPattern, SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Enumerate the files of this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is TopDirectoryOnly.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An enumerable collection of files that matches searchPattern and searchOption.</returns>
        public IEnumerable<S3FileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption)
        {
            IEnumerable<S3FileInfo> files = null;
            if (String.IsNullOrEmpty(bucket))
            {
                files = new List<S3FileInfo>();
            }
            else
            {
                var request = new ListObjectsRequest
                {
                    BucketName = bucket,
                    Delimiter = "/",
                    Prefix = S3Helper.EncodeKey(key)
                };
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).AddBeforeRequestHandler(S3Helper.FileIORequestEventHandler);
                files = new EnumerableConverter<S3Object, S3FileInfo>
                    (((IEnumerable<S3Object>)(PaginatedResourceFactory.Create<S3Object, ListObjectsRequest, ListObjectsResponse>(new PaginatedResourceInfo()
                            .WithClient(s3Client)
                            .WithMethodName("ListObjects")
                            .WithRequest(request)
                            .WithItemListPropertyPath("S3Objects")
                            .WithTokenRequestPropertyPath("Marker")
                            .WithTokenResponsePropertyPath("NextMarker"))))
                        .Where(s3Object => !String.Equals(S3Helper.DecodeKey(s3Object.Key), key, StringComparison.Ordinal) && !s3Object.Key.EndsWith("\\", StringComparison.Ordinal)),
                        s3Object => new S3FileInfo(s3Client, bucket, S3Helper.DecodeKey(s3Object.Key)));
            }

            //handle if recursion is set
            if (searchOption == SearchOption.AllDirectories)
            {
                IEnumerable<S3DirectoryInfo> foldersToSearch = EnumerateDirectories();
                foreach (S3DirectoryInfo dir in foldersToSearch)
                {
                    files = files.Concat(dir.EnumerateFiles(searchPattern, searchOption));
                }
            }

            //filter based on search pattern
            var regEx = WildcardToRegex(searchPattern);
            files = files.Where(s3fileInfo => Regex.IsMatch(s3fileInfo.Name, regEx, RegexOptions.IgnoreCase));
            return files;
        }

        /// <summary>
        /// Enumerate the files of this directory.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An enumerable collection of files.</returns>
        public IEnumerable<IS3FileSystemInfo> EnumerateFileSystemInfos()
        {
            return EnumerateFileSystemInfos("*", SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Enumerate the files of this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An enumerable collection of files that matches searchPattern.</returns>
        public IEnumerable<IS3FileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            return EnumerateFileSystemInfos(searchPattern, SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Enumerate the files of this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is TopDirectoryOnly.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An enumerable collection of files that matches searchPattern and searchOption.</returns>
        public IEnumerable<IS3FileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            IEnumerable<IS3FileSystemInfo> files = EnumerateFiles(searchPattern, searchOption).Cast<IS3FileSystemInfo>();
            IEnumerable<IS3FileSystemInfo> folders = EnumerateDirectories(searchPattern, searchOption).Cast<IS3FileSystemInfo>();

            return files.Concat(folders);
        }

        /// <summary>
        /// Returns the S3DirectoryInfo for the specified sub directory.
        /// </summary>
        /// <param name="directory">Directory to get the S3DirectroyInfo for.</param>
        /// <returns>The S3DirectoryInfo for the specified sub directory.</returns>
        public S3DirectoryInfo GetDirectory(string directory)
        {
            S3DirectoryInfo ret = null;
            if (String.IsNullOrEmpty(bucket))
            {
                ret = new S3DirectoryInfo(s3Client, directory, "");
            }
            else
            {
                ret = new S3DirectoryInfo(s3Client, bucket, string.Format(CultureInfo.InvariantCulture, "{0}{1}", key, directory));
            }
            return ret;
        }

        /// <summary>
        /// Returns an array of S3DirectoryInfos for the directories in this directory.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An array of directories.</returns>
        public S3DirectoryInfo[] GetDirectories()
        {
            return GetDirectories("*", SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Returns an array of S3DirectoryInfos for the directories in this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param>
        /// <returns>An array of files that matches searchPattern.</returns>
        public S3DirectoryInfo[] GetDirectories(string searchPattern)
        {
            return GetDirectories(searchPattern, SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Returns an array of S3DirectoryInfos for the directories in this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all directories.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is TopDirectoryOnly.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An array of directories that matches searchPattern and searchOption.</returns>
        public S3DirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            return EnumerateDirectories(searchPattern, searchOption).ToArray();
        }

        /// <summary>
        /// Returns the S3FileInfo for the specified file.
        /// </summary>
        /// <param name="filename">File to get the S3FileInfo for.</param>
        /// <returns>The S3FileInfo for the specified file.</returns>
        public S3FileInfo GetFile(string filename)
        {
            S3FileInfo ret = null;
            if (String.IsNullOrEmpty(bucket))
            {
                throw new NotSupportedException("Cannot create files in the root of s3, you need a bucket");
            }
            else
            {
                ret = new S3FileInfo(s3Client, bucket, string.Format(CultureInfo.InvariantCulture, "{0}{1}", key, filename));
            }
            return ret;
        }

        /// <summary>
        /// Returns an array of S3FileInfos for the files in this directory.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An array of files.</returns>
        public S3FileInfo[] GetFiles()
        {
            return GetFiles("*", SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Returns an array of S3FileInfos for the files in this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An array of files that matches searchPattern.</returns>
        public S3FileInfo[] GetFiles(string searchPattern)
        {
            return GetFiles(searchPattern, SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Returns an array of S3FileInfos for the files in this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is TopDirectoryOnly.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An array of files that matches searchPattern and searchOption.</returns>
        public S3FileInfo[] GetFiles(string searchPattern, SearchOption searchOption)
        {
            return EnumerateFiles(searchPattern, searchOption).ToArray();
        }

        /// <summary>
        /// Returns an array of IS3FileSystemInfos for the files in this directory.
        /// </summary>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An array of files.</returns>
        public IS3FileSystemInfo[] GetFileSystemInfos()
        {
            return GetFileSystemInfos("*",SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Returns an array of IS3FileSystemInfos for the files in this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An array of files that matches searchPattern.</returns>
        public IS3FileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
            return GetFileSystemInfos(searchPattern, SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// Returns an array of IS3FileSystemInfos for the files in this directory.
        /// </summary>
        /// <param name="searchPattern">The search string. The default pattern is "*", which returns all files.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or all subdirectories. The default value is TopDirectoryOnly.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An array of files that matches searchPattern and searchOption.</returns>
        public IS3FileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return EnumerateFileSystemInfos(searchPattern, searchOption).ToArray();
        }

        /// <summary>
        /// Copies the files from this directory to the target directory specified by the bucket and object key.
        /// </summary>
        /// <param name="newBucket">The target bucket to copy to.</param>
        /// <param name="newKey">The target object key which represents a directory in S3.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>S3DirectoryInfo for the target location.</returns>
        public S3DirectoryInfo CopyTo(string newBucket, string newKey)
        {
            return CopyTo(newBucket, newKey, DateTime.MinValue);
        }

        /// <summary>
        /// Copies the files from this directory to the target directory specified by the bucket and object key.  Only
        /// files that have changed since the changeSince date will be copied.
        /// </summary>
        /// <param name="newBucket">The target bucket to copy to.</param>
        /// <param name="newKey">The target object key which represents a directory in S3.</param>
        /// <param name="changesSince">Date which files must have changed since in ordered to be copied.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>S3DirectoryInfo for the target location.</returns>
        public S3DirectoryInfo CopyTo(string newBucket, string newKey, DateTime changesSince)
        {
            S3DirectoryInfo newLoc = new S3DirectoryInfo(s3Client, newBucket, newKey);
            return CopyTo(newLoc, changesSince);
        }

        /// <summary>
        /// Copies the files from this directory to the target directory.
        /// </summary>
        /// <param name="newLoc">The target directory to copy to.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>S3DirectoryInfo for the target location.</returns>
        public S3DirectoryInfo CopyTo(S3DirectoryInfo newLoc)
        {
            return CopyTo(newLoc, DateTime.MinValue);
        }

        /// <summary>
        /// Copies the files from this directory to the target directory.  Only
        /// files that have changed since the changeSince date will be copied.
        /// </summary>
        /// <param name="newLoc">The target directory to copy to.</param>
        /// <param name="changesSince">Date which files must have changed since in ordered to be copied.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>S3DirectoryInfo for the target location.</returns>
        public S3DirectoryInfo CopyTo(S3DirectoryInfo newLoc, DateTime changesSince)
        {
            if (!newLoc.Exists)
            {
                throw new ArgumentException("Destination for CopyTo operation does not exist.", "newLoc");
            }

            if (LastWriteTime > changesSince)
            {
                foreach (S3DirectoryInfo dir in EnumerateDirectories())
                {
                    S3DirectoryInfo subLoc = newLoc.CreateSubdirectory(dir.Name);
                    dir.CopyTo(subLoc, changesSince);
                }

                foreach (S3FileInfo file in EnumerateFiles())
                {
                    if (file.LastWriteTime > changesSince)
                    {
                        file.CopyTo(newLoc);
                    }
                }
            }

            return newLoc;
        }

        /// <summary>
        /// Copies the files from the S3 directory to the local file system in the location indicated by the path parameter.
        /// </summary>
        /// <param name="path">The location on the local file system to copy the files to.</param>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>DirectoryInfo for the local directory where files are copied to.</returns>
        public DirectoryInfo CopyToLocal(string path)
        {
            return CopyToLocal(path, DateTime.MinValue);
        }

        /// <summary>
        /// Copies the files from the S3 directory to the local file system in the location indicated by the path parameter.
        /// Only files that have been modified since the changesSince property will be copied.
        /// </summary>
        /// <param name="path">The location on the local file system to copy the files to.</param>
        /// <param name="changesSince">Date which files must have changed since in ordered to be copied.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>DirectoryInfo for the local directory where files are copied to.</returns>
        public DirectoryInfo CopyToLocal(string path, DateTime changesSince)
        {
            if (!Directory.Exists(path))
            {
                throw new ArgumentException("Destiation for CopyTo operation does not exist.", "path");
            }

            if (LastWriteTime > changesSince)
            {
                foreach (S3DirectoryInfo dir in EnumerateDirectories())
                {
                    DirectoryInfo newLoc = Directory.CreateDirectory(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", path, dir.Name));
                    dir.CopyToLocal(newLoc.FullName, changesSince);
                }

                foreach (S3FileInfo file in EnumerateFiles())
                {
                    if (file.LastWriteTime > changesSince)
                    {
                        file.CopyToLocal(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", path, file.Name));
                    }
                }
            }

            return new DirectoryInfo(path);
        }

        /// <summary>
        /// Copies files from the local file system to S3 in this directory.  Sub directories are copied as well.
        /// </summary>
        /// <param name="path">The local file system path where the files are to be copied.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>S3DirectoryInfo where the files are copied to.</returns>
        public S3DirectoryInfo CopyFromLocal(string path)
        {
            return CopyFromLocal(path, DateTime.MinValue);
        }

        /// <summary>
        /// Copies files from the local file system to S3 in this directory.  Sub directories are copied as well.  
        /// Only files that have been modified since the changesSince property will be copied.
        /// </summary>
        /// <param name="path">The local file system path where the files are to copy.</param>
        /// <param name="changesSince">Date which files must have changed since in ordered to be copied.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>S3DirectoryInfo where the files are copied to.</returns>
        public S3DirectoryInfo CopyFromLocal(string path, DateTime changesSince)
        {
            DirectoryInfo sourceLoc = new DirectoryInfo(path);

            if (!sourceLoc.Exists)
            {
                throw new ArgumentException("Source for CopyFrom operation does not exist.", "path");
            }

            sourceLoc.Refresh();
            if (sourceLoc.LastWriteTime > changesSince)
            {
                foreach (DirectoryInfo dir in sourceLoc.GetDirectories())
                {
                    S3DirectoryInfo newLoc = CreateSubdirectory(dir.Name);
                    newLoc.CopyFromLocal(dir.FullName, changesSince);
                }

                foreach (FileInfo file in sourceLoc.GetFiles())
                {
                    file.Refresh();
                    if (file.LastWriteTime > changesSince)
                    {
                        this.GetFile(file.Name).CopyFromLocal(file.FullName);
                    }
                }
            }
            return this;
        }

        /// <summary>
        /// Moves the directory to the target directory specified by the bucket and object key.
        /// </summary>
        /// <param name="newBucket">The target bucket to move to.</param>
        /// <param name="newKey">The target object key which represents a directory in S3.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>S3DirectoryInfo for the target location.</returns>
        public S3DirectoryInfo MoveTo(string newBucket, string newKey)
        {
            S3DirectoryInfo newLoc = new S3DirectoryInfo(s3Client, newBucket, newKey);
            return MoveTo(newLoc);
        }

        /// <summary>
        /// Moves the directory to the target S3 directory.
        /// </summary>
        /// <param name="newLoc">The target directory to copy to.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>S3DirectoryInfo for the target location.</returns>
        public S3DirectoryInfo MoveTo(S3DirectoryInfo newLoc)
        {
            if (!newLoc.Exists)
            {
                throw new ArgumentException("Destiation for MoveTo operation does not exist.", "newLoc");
            }

            S3DirectoryInfo newSub = newLoc.CreateSubdirectory(Name);

            foreach (S3DirectoryInfo dir in EnumerateDirectories())
            {
                dir.MoveTo(newSub);
            }

            foreach (S3FileInfo file in EnumerateFiles())
            {
                file.MoveTo(newSub);
            }

            Delete();

            return newLoc;
        }

        /// <summary>
        /// Moves the files from the S3 directory to the local file system in the location indicated by the path parameter.
        /// </summary>
        /// <param name="path">The location on the local file system to move the files to.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>DirectoryInfo for the local directory where files are moved to.</returns>
        public DirectoryInfo MoveToLocal(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new ArgumentException("Destiation for MoveTo operation does not exist.", "path");
            }
           
            foreach (S3DirectoryInfo dir in EnumerateDirectories())
            {
                DirectoryInfo newLoc = Directory.CreateDirectory(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", path, dir.Name));
                dir.MoveToLocal(newLoc.FullName);
            }

            foreach (S3FileInfo file in EnumerateFiles())
            {
                file.MoveToLocal(string.Format(CultureInfo.InvariantCulture, "{0}\\{1}", path, file.Name));
            }

            Delete();

            return new DirectoryInfo(path);
        }

        /// <summary>
        /// Moves files from the local file system to S3 in this directory.  Sub directories are moved as well.
        /// </summary>
        /// <param name="path">The local file system path where the files are to be moved.</param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>S3DirectoryInfo where the files are moved to.</returns>
        public S3DirectoryInfo MoveFromLocal(string path)
        {
            DirectoryInfo sourceLoc = new DirectoryInfo(path);

            if (!sourceLoc.Exists)
            {
                throw new ArgumentException("Source for MoveFrom operation does not exist.", "path");
            }

            foreach (DirectoryInfo dir in sourceLoc.GetDirectories())
            {
                S3DirectoryInfo newLoc = CreateSubdirectory(dir.Name);
                newLoc.MoveFromLocal(dir.FullName);
            }

            foreach (FileInfo file in sourceLoc.GetFiles())
            {
                this.GetFile(file.Name).MoveFromLocal(file.FullName);
            }

            sourceLoc.Delete();
            return this;
        }

        /// <summary>
        /// Implement the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return FullName;
        }


        static string WildcardToRegex(string pattern)
        {
            string newPattern = Regex.Escape(pattern).
                Replace("\\*", ".*").
                Replace("\\?", ".");
            return "^" + newPattern + "$";
        }

        /// <summary>
        /// Creating and deleting buckets can sometimes take a little bit of time.  To make sure
        /// users of this API do not experience the side effects of the eventual consistency
        /// we block until the state change has happened.
        /// </summary>
        /// <param name="exists"></param>
        void WaitTillBucketS3StateIsConsistent(bool exists)
        {
            int success = 0;
            bool currentState = false;
            long start = DateTime.Now.Ticks;
            do
            {
                var buckets = this.S3Client.ListBuckets().Buckets;
                currentState = buckets.FirstOrDefault(x => string.Equals(x.BucketName, this.BucketName)) != null;

                if (currentState == exists)
                {
                    success++;

                    if (success == EVENTUAL_CONSISTENCY_SUCCESS_IN_ROW)
                        break;
                }
                else
                {
                    success = 0;
                }

                Thread.Sleep(EVENTUAL_CONSISTENCY_POLLING_PERIOD);

            } while (new TimeSpan(DateTime.Now.Ticks - start).TotalMilliseconds < EVENTUAL_CONSISTENCY_MAX_WAIT) ;
        }
    }

    internal class EnumerableConverter<T, U> : IEnumerable<U>
    {
        internal IEnumerable<T> baseEnum = null;
        internal Func<T, U> converter = null;

        internal EnumerableConverter(IEnumerable<T> start, Func<T, U> convert)
        {
            baseEnum = start;
            converter = convert;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public IEnumerator<U> GetEnumerator()
        {
            return new ConvertingEnumerator<T, U>(this);
        }
    }

    internal class ConvertingEnumerator<T, U> : IEnumerator<U>
    {
        Func<T, U> convert;
        IEnumerator<T> getT;

        bool isConverted = false;
        U convertedCurrent = default(U);

        internal ConvertingEnumerator(EnumerableConverter<T, U> ec)
        {
            getT = ec.baseEnum.GetEnumerator();
            convert = ec.converter;
        }

        public bool MoveNext()
        {
            isConverted = false;
            convertedCurrent = default(U);
            return getT.MoveNext();
        }

        public void Reset()
        {
            isConverted = false;
            convertedCurrent = default(U);
            getT.Reset();
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public U Current
        {
            get
            {
                if (!isConverted)
                {
                    convertedCurrent = convert(getT.Current);
                    isConverted = true;
                }
                return convertedCurrent;
            }
        }

        public void Dispose()
        {
        }
    }
}
