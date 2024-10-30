/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using Amazon.S3.Transfer.Internal;
using Amazon.Util;
using System.Globalization;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.Runtime.Telemetry;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// 	<para>
    /// 	Provides a high level utility for managing transfers to and from Amazon S3.
    /// 	</para>
    /// 	<para>
    /// 	<c>TransferUtility</c> provides a simple API for 
    /// 	uploading content to and downloading content
    /// 	from Amazon S3. It makes extensive use of Amazon S3 multipart uploads to
    /// 	achieve enhanced throughput, performance, and reliability. 
    /// 	</para>
    /// 	<para>
    /// 	When uploading large files by specifying file paths instead of a stream, 
    /// 	<c>TransferUtility</c> uses multiple threads to upload
    /// 	multiple parts of a single upload at once. When dealing with large content
    /// 	sizes and high bandwidth, this can increase throughput significantly.
    /// 	</para>
    /// </summary>
    /// <remarks>
    /// 	<para>
    /// 	Transfers are stored in memory. If the application is restarted, 
    /// 	previous transfers are no longer accessible. In this situation, if necessary, 
    /// 	you should clean up any multipart uploads that are incomplete.
    /// 	</para>
    /// </remarks>
    public partial class TransferUtility : ITransferUtility
    {
        private readonly string S3TransferTracerScope = $"S3.Transfer";

        TransferUtilityConfig _config;
        IAmazonS3 _s3Client;
        bool _shouldDispose = false;
        bool _isDisposed;
        private HashSet<string> blockedServiceNames = new HashSet<string>
        {
            "s3-object-lambda"
        };
        private static Logger Logger
        {
            get
            {

                return Logger.GetLogger(typeof(ITransferUtility));
            }
        }
        #region Constructors

        /// <summary>
        /// 	Constructs a new <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// 	The AWS Access Key ID.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// 	The AWS Secret Access Key.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey)
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey))
        {
            this._shouldDispose = true;
        }

        /// <summary>
        /// 	Constructs a new <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// 	The AWS Access Key ID.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// 	The AWS Secret Access Key.
        /// </param>
        /// <param name="region">
        ///     The region to configure the transfer utility for.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey, region))
        {
            this._shouldDispose = true;
        }

        /// <summary>
        /// 	Constructs a new instance of the <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// 	The AWS Access Key ID.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// 	The AWS Secret Access Key.
        /// </param>
        /// <param name="config">
        /// 	Specifies advanced settings.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, TransferUtilityConfig config)
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey), config)
        {
            this._shouldDispose = true;
        }

        /// <summary>
        /// 	Constructs a new instance of the <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// 	The AWS Access Key ID.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// 	The AWS Secret Access Key.
        /// </param>
        /// <param name="region">
        ///     The region to configure the transfer utility for.
        /// </param>
        /// <param name="config">
        /// 	Specifies advanced settings.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region, TransferUtilityConfig config)
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey, region), config)
        {
            this._shouldDispose = true;
        }


        /// <summary>
        /// 	Constructs a new instance of the <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="s3Client">
        /// 	The Amazon S3 client.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(IAmazonS3 s3Client)
            : this(s3Client, new TransferUtilityConfig())
        {
        }

        /// <summary>
        /// 	Initializes a new instance of the <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="s3Client">
        /// 	The Amazon S3 client.
        /// </param>
        /// <param name="config">
        /// 	Specifies advanced configuration settings for <see cref="TransferUtility"/>.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(IAmazonS3 s3Client, TransferUtilityConfig config)
        {
            this._s3Client = s3Client;
            this._config = config;
        }

        /// <summary>
        /// 	Constructs a new <see cref="TransferUtility"/> class.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility()
            : this(new AmazonS3Client())
        {
            this._shouldDispose = true;
        }

        /// <summary>
        /// 	Constructs a new <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="region">
        ///     The region to configure the transfer utility for.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(RegionEndpoint region)
            : this(new AmazonS3Client(region))
        {
            this._shouldDispose = true;
        }

        /// <summary>
        /// 	Constructs a new <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="config">
        /// 	Specifies advanced configuration settings for <see cref="TransferUtility"/>.
        /// </param>
        /// <remarks>
        /// </remarks>
        public TransferUtility(TransferUtilityConfig config)
            : this(new AmazonS3Client(), config)
        {
            this._shouldDispose = true;
            this._config = config;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 	Gets the Amazon S3 client used for making calls into Amazon S3.
        /// </summary>
        /// <value>
        /// 	The Amazon S3 client used for making calls into Amazon S3.
        /// </value>
        public IAmazonS3 S3Client
        {
            get
            {
                return this._s3Client;
            }
        }

        #endregion

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this._isDisposed)
            {
                if (disposing && _s3Client != null && _shouldDispose)
                {
                    _s3Client.Dispose();
                    _s3Client = null;
                }
                this._isDisposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        private void CheckForBlockedArn(string bucketName, string command)
        {
            if (Arn.IsArn(bucketName))
            {
                Arn s3Arn = Arn.Parse(bucketName);
                if (blockedServiceNames.Contains(s3Arn.Service))
                {
                    if (s3Arn.IsService("s3-object-lambda"))
                        throw new AmazonS3Exception($"{command} does not support S3 Object Lambda resources");
                }
            }
        }

        private static TransferUtilityUploadRequest ConstructUploadRequest(string filePath, string bucketName)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }
#if BCL     // Validations for Win RT/Win Phone are done in GetUploadCommand method's call to validate.
            if (!File.Exists(filePath))
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The file {0} does not exist!", filePath));
            }
#endif
            return new TransferUtilityUploadRequest()
            {
                BucketName = bucketName,
                FilePath = filePath
            };
        }

        private static TransferUtilityUploadRequest ConstructUploadRequest(string filePath, string bucketName, string key)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }
#if BCL     // Validations for Win RT/Win Phone are done in GetUploadCommand method's call to validate.
            if (!File.Exists(filePath))
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The file {0} does not exist!", filePath));
            }
# endif
            return new TransferUtilityUploadRequest()
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };
        }

        private static TransferUtilityUploadRequest ConstructUploadRequest(Stream stream, string bucketName, string key)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }

            return new TransferUtilityUploadRequest()
            {
                BucketName = bucketName,
                Key = key,
                InputStream = stream
            };
        }

        internal BaseCommand GetUploadCommand(TransferUtilityUploadRequest request)
        {
            validate(request);

            if (IsMultipartUpload(request))
            {
                return new MultipartUploadCommand(this._s3Client, this._config, request);
            }
            else
            {
                return new SimpleUploadCommand(this._s3Client, this._config, request);
            }
        }

        bool IsMultipartUpload(TransferUtilityUploadRequest request)
        {
            //If the length is -1 that means when we tried to get the ContentLength, we caught a NotSupportedException
            //or it means the length is unknown. In this case we do a multpartupload. If we are uploading
            //a nonseekable stream and the ContentLength is more than zero, we also do a multipart upload.
            if (request.ContentLength <= 0 && request.InputStream != null && !request.InputStream.CanSeek)
            {
                return true;
            }
            return request.ContentLength >= this._config.MinSizeBeforePartUpload;
        }

        static void validate(TransferUtilityUploadRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            if (!request.IsSetBucketName())
            {
                throw new InvalidOperationException("Please specify BucketName to PUT an object into Amazon S3.");
            }
            if (!request.IsSetFilePath() &&
                !request.IsSetInputStream())
            {
                throw new InvalidOperationException(
                    "Please specify either a Filename or provide a Stream to PUT an object into Amazon S3.");
            }
            if (!request.IsSetKey())
            {
                if (request.IsSetFilePath())
                {
                    request.Key = Path.GetFileName(request.FilePath);
                }
                else
                {
                    throw new ArgumentException(
                        "The Key property must be specified when using a Stream to upload into Amazon S3.");
                }
            }
            if (request.IsSetFilePath())
            {
                bool fileExists;
                fileExists = File.Exists(request.FilePath);
                if (!fileExists)
                {
                    throw new ArgumentException("The file indicated by the FilePath property does not exist!");
                }
            }
        }

        private static TransferUtilityDownloadRequest ConstructDownloadRequest(string filePath, string bucketName, string key)
        {
            return new TransferUtilityDownloadRequest()
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };
        }

        private static TransferUtilityDownloadDirectoryRequest ConstructDownloadDirectoryRequest(string bucketName, string s3Directory, string localDirectory)
        {
            return new TransferUtilityDownloadDirectoryRequest()
            {
                BucketName = bucketName,
                S3Directory = s3Directory,
                LocalDirectory = localDirectory
            };
        }

        static void validate(TransferUtilityUploadDirectoryRequest request)
        {
            if (!request.IsSetDirectory())
            {
                throw new InvalidOperationException("Directory not specified");
            }
            if (!request.IsSetBucketName())
            {
                throw new InvalidOperationException("BucketName not specified");
            }
            if (!Directory.Exists(request.Directory))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "The directory {0} does not exists!",
                    request.Directory));
            }
        }

        private static TransferUtilityUploadDirectoryRequest ConstructUploadDirectoryRequest(string directory, string bucketName)
        {
            return new TransferUtilityUploadDirectoryRequest()
            {
                BucketName = bucketName,
                Directory = directory
            };
        }

        private static TransferUtilityUploadDirectoryRequest ConstructUploadDirectoryRequest(string directory, string bucketName, string searchPattern, SearchOption searchOption)
        {
            return new TransferUtilityUploadDirectoryRequest()
            {
                BucketName = bucketName,
                Directory = directory,
                SearchPattern = searchPattern,
                SearchOption = searchOption
            };
        }

        /// <summary>
        /// Creates a new span with the required attributes.
        /// </summary>
        /// <param name="methodName">The name of the method from which to create the span name.</param>
        /// <param name="initialAttributes">Optional initial set of attributes for the span.</param>
        /// <param name="spanKind">Optional type of span to create.</param>
        /// <param name="parentContext">Optional parent context for the span.</param>
        /// <returns>A <see cref="TraceSpan"/> instance representing the created span.</returns>
        private TraceSpan CreateSpan(
            string methodName,
            Attributes initialAttributes = null,
            SpanKind spanKind = SpanKind.INTERNAL,
            SpanContext parentContext = null)
        {
            if (initialAttributes == null)
                initialAttributes = new Attributes();

            // Add common attributes
            var operationName = ExtractOperationName(methodName);
            initialAttributes.Set(TelemetryConstants.MethodAttributeKey, operationName);

            initialAttributes.Set(TelemetryConstants.SystemAttributeKey, TelemetryConstants.SystemAttributeValue);
            initialAttributes.Set(TelemetryConstants.ServiceAttributeKey, S3TransferTracerScope);

            var spanName = $"{nameof(TransferUtility)}.{operationName}";

            var tracerProvider = this._s3Client.Config.TelemetryProvider.TracerProvider;

            var tracer = tracerProvider.GetTracer($"{TelemetryConstants.TelemetryScopePrefix}.{S3TransferTracerScope}");

            return tracer.CreateSpan(spanName, initialAttributes, spanKind, parentContext);
        }

        /// <summary>
        /// Extracts the operation name from a given method name.
        /// </summary>
        /// <param name="methodName">The name of the method for which the operation name is to be extracted.</param>
        /// <returns>
        /// The operation name if the method name ends with "Async"; otherwise, returns the original method name.
        /// </returns>
        private string ExtractOperationName(string methodName)
        {
            if (methodName.EndsWith("Async", StringComparison.Ordinal))
            {
                return methodName.Substring(0, methodName.Length - 5);
            }
            return methodName;
        }

    }
}
