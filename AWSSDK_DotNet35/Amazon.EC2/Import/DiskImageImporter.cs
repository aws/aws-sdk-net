/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

using Amazon.Runtime;
using Amazon.Util;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.EC2.Model;

namespace Amazon.EC2.Import
{
#if BCL
    /// <summary>
    /// Callback signature to report progress on the manifest creation and upload process.
    /// </summary>
    /// <param name="message">Describes the current in-progress task</param>
    /// <param name="percentComplete">If not null, the percentage completion of the image file upload</param>
    public delegate void ImportProgressCallback(string message, int? percentComplete);

    /// <summary>
    /// Helper class to import a virtual machine image or disk image to Amazon EC2 
	/// using Amazon S3 to hold the in-flight artifacts.
    /// </summary>
    public class DiskImageImporter
    {
        const string ManifestFileVersion = "2010-11-15";
        const string ManifestFileImporterName = "ec2-upload-disk-image";
        const string ManifestFileImporterVersion = "1.0.0";
        const string ManifestFileImporterRelease = ManifestFileVersion;

        const string ManifestSuffix = "manifest.xml";
        const string PartSuffix = "part";

        const long OneMb = 1024 * 1024;
        const long OneGb = 1024 * OneMb;

        const long DefaultPartSize = 10 * OneMb;

        /// <summary>
        /// The default number of threads that will be used to upload the parts comprising
        /// the image file. Each thread will consume a 10MB buffer to process the part data.
        /// </summary>
        public const int DefaultUploadThreads = 10;

        /// <summary>
        /// The default validity period for the signed Amazon S3 URLs that allow Amazon EC2
        /// to access the manifest.
        /// </summary>
        public const int DefaultUrlExpirationInDays = 30;

        /// <summary>
        /// The maximum number of threads that can be used to upload the image file parts.
        /// </summary>
        public const int MaxUploadThreads = 30;

        /// <summary>
        /// <para>
        /// The number of threads to use to upload the image file parts to Amazon S3.
        /// Each thread will consume a 10MB buffer to process the part data.
        /// </para>
        /// <para>
        /// Default: 10. Max: 30.
        /// </para>
        /// </summary>
        public int UploadThreads
        {
            get { return _uploadThreads; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Expected value between 1 and " + MaxUploadThreads);
                _uploadThreads = value > MaxUploadThreads ? MaxUploadThreads : value;
            }
        }

        /// <summary>
        /// The set of file formats recognised by Amazon EC2 import/conversion
        /// </summary>
        public static readonly string[] ValidFileFormats = { "VMDK", "RAW", "VHD" };

        /// <summary>
        /// The constructed manifest describing the import artifacts.
        /// </summary>
        public ImportManifestRoot ImportManifest { get; private set; }

        /// <summary>
        /// The absolute path to the image file being imported.
        /// </summary>
        public string ImageFilePath { get; private set; }

        /// <summary>
        /// The Amazon S3 object key to the uploaded manifest file.
        /// </summary>
        public string ManifestFileKey { get; protected set; }

        /// <summary>
		/// <para>
        /// Controls Amazon S3 clean-up of image file and import manifest artifacts 
        /// if an error occurs during upload.
		/// </para>
        /// <para>
        /// By default, if an error occurs when uploading the image file to S3 the
        /// importer will exit and leave what has been uploaded still present in S3.
        /// This enables a 'resume mode' where the importer can be run again to 
        /// continue upload of the remaining parts based on inspection of the bucket
        /// vs the manifest. Note that this does leave the potential for storage costs
        /// if the user decides to abandon the import (the PowerShell cmdlets that use
		/// this importer emit error messages detailing the resume/cleanup instructions).
        /// </para>
        /// <para>
        /// If this option is set, the importer instead automatically cleans the bucket 
        /// of all uploaded content on error. 
        /// </para>
        /// </summary>
        public bool RollbackOnUploadError { get; set; }

        /// <summary>
        /// The maximum age, in days, before the Amazon S3 presigned urls 
        /// generated in the import manifest expire. The default value
        /// is 30. Note that for AWS regions that require Signature Version 4 
        /// request signing, the maximum value will not exceed 7 days.
        /// </summary>
        public int UrlExpirationInDays
        {
            get { return _urlExpirationInDays; }
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("Expected a value of 1 or greater.");
                _urlExpirationInDays = value;
            }
        }

        /// <summary>
        /// The name of the bucket that will hold the artifacts. An attempt will
        /// be made to create the bucket if it does not already exist.
        /// </summary>
        public string BucketName { get; private set; }

        /// <summary>
        /// S3 object key beneath which all artifacts will be uploaded in
        /// the bucket; by convention this is a GUID preceeded by any custom 
        /// prefix the user has specified.
        /// </summary>
        public string ArtifactsKeyPrefix { get; private set; }

        /// <summary>
        /// The region in which the import will take place.
        /// </summary>
        public RegionEndpoint Region { get; private set; }

        /// <summary>
        /// Client for S3 operations, created using the credentials and region scoping 
        /// we are handed on construction, or assigned from an existing S3 client instance.
        /// </summary>
        public IAmazonS3 S3Client { get; private set; }

        /// <summary>
        /// Client for EC2 operations, created using the credentials and region scoping 
        /// we are handed on construction, or assigned from an existing EC2 client instance.
        /// </summary>
        public IAmazonEC2 EC2Client { get; private set; }

        private string _presignedManifestUrl;
        private int _urlExpirationInDays = DefaultUrlExpirationInDays;
        private int _uploadThreads = DefaultUploadThreads;

        private static int _activeUploadWorkers = 0;

        /// <summary>
        /// Constructs an image importer to upload and convert virtual machine image 
        /// or disk volumes for use with Amazon EC2. AWS credentials will be obtained from
        /// the application configuration settings.
        /// </summary>
        /// <param name="region">
        /// The region to which the artifacts will be uploaded and EC2 conversion performed.
        /// </param>
        /// <param name="bucketName">
        /// The name of the Amazon S3 bucket that will contain the uploaded image and manifest. If the bucket 
        /// does not exist it will be created.
        /// </param>
        public DiskImageImporter(RegionEndpoint region, string bucketName)
        {
            Region = region;
            BucketName = bucketName;

            EC2Client = new AmazonEC2Client(Region);
            S3Client = new AmazonS3Client(Region);
        }

        /// <summary>
        /// Constructs an image importer to upload and convert virtual machine image 
        /// or disk volumes for use with Amazon EC2. The importer will use the supplied
        /// clients for communicating with Amazon S3 and Amazon EC2. Note that the clients
        /// should be configured to use the same region and AWS account.
        /// </summary>
        /// <param name="s3Client">Client to use to upload artifacts to Amazon S3</param>
        /// <param name="ec2Client">Client to use to request image conversion in Amazon EC2</param>
        /// <param name="bucketName">
        /// The name of the Amazon S3 bucket that will contain the uploaded image and manifest. If the bucket 
        /// does not exist it will be created.
        /// </param>
        public DiskImageImporter(IAmazonS3 s3Client, IAmazonEC2 ec2Client, string bucketName)
        {
            S3Client = s3Client;
            EC2Client = ec2Client;
            BucketName = bucketName;
        }

        /// <summary>
        /// Constructs an image importer to upload and convert virtual machine image 
        /// or disk volumes for use with Amazon EC2.
        /// </summary>
        /// <param name="credentials">
		/// The AWS credentials of the account that will own the uploaded artifacts.
		/// </param>
        /// <param name="region">
		/// The region to which the artifacts will be uploaded and EC2 conversion performed.
		/// </param>
        /// <param name="bucketName">
		/// The name of the Amazon S3 bucket that will contain the uploaded image and manifest. If the bucket 
		/// does not exist it will be created.
		/// </param>
        public DiskImageImporter(AWSCredentials credentials, RegionEndpoint region, string bucketName)
        {
            Region = region;
            BucketName = bucketName;

            EC2Client = new AmazonEC2Client(credentials, Region);
            S3Client = new AmazonS3Client(credentials, Region);
        }

        /// <summary>
        /// Uploads and requests import conversion of a virtual machine image file
        /// to an Amazon EC2 instance.
        /// </summary>
        /// <param name="imageFilepath">The full path to the image file to be processed</param>
        /// <param name="fileFormat">
        /// The format of the image file (VMDK | RAW | VHD). If not specified, it will be inferred
        /// from the extension of the image file.
        /// </param>
        /// <param name="volumeSize">
        /// The requested size (in GiB) for the resulting image volume. If not specified a suitable 
        /// value based on the size of the image file is used. Note that the minimum required boot 
        /// volume size for EC2 is 8GB.
        /// </param>
        /// <param name="keyPrefix">
        /// Optional root-level key prefix that will be applied to the uploaded artifacts in S3.
        /// The artifacts will be placed beneath this (or the root if not set) in a key composed
        /// of a GUID.
        /// </param>
        /// <param name="launchConfiguration">Launch configuration settings for the imported instance</param>
        /// <param name="progressCallback">Optional callback delegate for upload progress reporting</param>
        /// <returns>
        /// The service response containing a ConversionTask object that can be used to monitor the progress of the 
        /// requested conversion.
        /// </returns>
        public ImportInstanceResponse ImportInstance(string imageFilepath,
                                                     string fileFormat,
                                                     long? volumeSize,
                                                     string keyPrefix,
                                                     ImportLaunchConfiguration launchConfiguration,
                                                     ImportProgressCallback progressCallback)
        {
            Upload(imageFilepath, fileFormat, volumeSize, keyPrefix, progressCallback, false);
            return StartInstanceConversion(launchConfiguration);
        }

        /// <summary>
        /// Uploads and requests import conversion of a virtual disk file to an Amazon EBS volume.
        /// </summary>
        /// <param name="imageFilepath">The full path to the image file to be processed</param>
        /// <param name="fileFormat">
        /// The format of the image file (VMDK | RAW | VHD). If not specified, it will be inferred
        /// from the extension of the image file.
        /// </param>
        /// <param name="volumeSize">
        /// The requested size (in GiB) for the resulting image volume. If not specified a suitable 
        /// value based on the size of the image file is used.
        /// </param>
        /// <param name="keyPrefix">
        /// Optional root-level key prefix that will be applied to the uploaded artifacts in S3.
        /// The artifacts will be placed beneath this (or the root if not set) in a key composed
        /// of a GUID.
        /// </param>
        /// <param name="availabilityZone">The Availability Zone for the resulting Amazon EBS volume.</param>
        /// <param name="description">An optional description for the volume being imported.</param>
        /// <param name="progressCallback">Optional callback delegate for upload progress reporting</param>
        /// <returns>
        /// The service response containing a ConversionTask object that can be used to monitor the progress of the 
        /// requested conversion.
        /// </returns>
        public ImportVolumeResponse ImportVolume(string imageFilepath,
                                                 string fileFormat,
                                                 long? volumeSize,
                                                 string keyPrefix,
                                                 string availabilityZone, 
                                                 string description,
                                                 ImportProgressCallback progressCallback)
        {
            Upload(imageFilepath, fileFormat, volumeSize, keyPrefix, progressCallback, false);
            return StartVolumeConversion(availabilityZone, description);
        }

        /// <summary>
        /// <para>
        /// Constructs the import manifest for the image and then uploads it and the 
        /// virtual machine image or disk image to Amazon S3. The S3 key to the uploaded 
        /// manifest file is returned.
        /// </para>
        /// <para>
        /// If an error occurs during upload of the image file the RetainArtifactsOnUploadError
        /// property governs whether the partially uploaded content is deleted or retained. If
        /// the content is retained, the import can be resumed. By default the 
        /// RetainArtifactsOnUploadError property is false and the content deleted, avoiding
        /// storage charges for potentially orphaned content if the command is not re-run.
        /// </para>
        /// </summary>
        /// <param name="imageFilepath">The full path to the image file to be processed</param>
        /// <returns>The S3 object key of the uploaded manifest file</returns>
        public string Upload(string imageFilepath)
        {
            return Upload(imageFilepath, null, null, null, null, false);
        }

        /// <summary>
        /// <para>
        /// Constructs the import manifest for the image and then uploads it and the 
        /// virtual machine image or disk image to Amazon S3. The S3 key to the uploaded 
        /// manifest file is returned.
        /// </para>
        /// <para>
        /// If an error occurs during upload of the image file the RetainArtifactsOnUploadError
        /// property governs whether the partially uploaded content is deleted or retained. If
        /// the content is retained, the import can be resumed. By default the 
        /// RetainArtifactsOnUploadError property is false and the content deleted, avoiding
        /// storage charges for potentially orphaned content if the command is not re-run.
        /// </para>
        /// </summary>
        /// <param name="imageFilepath">The full path to the image file to be processed</param>
        /// <param name="fileFormat">
        /// The format of the image file (VMDK | RAW | VHD). If not specified, it will be inferred
        /// from the extension of the image file.
        /// </param>
        /// <param name="volumeSize">
        /// The requested size (in GiB) for the resulting image volume. If not specified a suitable 
        /// value based on the size of the image file is used. Note that if importing a disk image that
        /// will be used as an EC2 instance, the minimum required boot volume size is 8GB.
        /// </param>
        /// <param name="keyPrefix">
        /// Optional root-level key prefix that will be applied to the uploaded artifacts in S3.
        /// The artifacts will be placed beneath this (or the root if not set) in a key composed
        /// of a GUID.
        /// </param>
        /// <param name="progressCallback">Optional callback delegate for upload progress reporting</param>
        /// <param name="resumeUpload">
        /// Set this to true if a previous upload failed part-way through processing and RetainArtifactsOnUploadError
        /// was set to true so the partially uploaded content was retained. The existing manifest will
        /// be inspected and uploads will resume of the retaining content.
        /// </param>
        /// <returns>The S3 object key of the uploaded manifest file</returns>
        public string Upload(string imageFilepath,
                             string fileFormat,
                             long? volumeSize,
                             string keyPrefix,
                             ImportProgressCallback progressCallback,
                             bool resumeUpload)
        {
            ImageFilePath = imageFilepath;

            if (!resumeUpload)
            {
                var guidPart = Guid.NewGuid().ToString("D");
                ArtifactsKeyPrefix 
                    = string.IsNullOrEmpty(keyPrefix) 
                        ? guidPart 
                        : string.Format(CultureInfo.InvariantCulture, "{0}/{1}", keyPrefix, guidPart);

                ImportManifest = CreateImportManifest(fileFormat, volumeSize);

                if (!AmazonS3Util.DoesS3BucketExist(S3Client, BucketName))
                    S3Client.PutBucket(new PutBucketRequest { BucketName = this.BucketName, UseClientRegion = true });

                UploadManifest(progressCallback);
            }

            UploadImageParts(progressCallback);
            return ManifestFileKey;
        }

        /// <summary>
        /// Constructs an importer instance for a previously uploaded manifest. The manifest is downloaded using 
        /// a new Amazon S3 client constructed for the specified region and deserialized, ready for use in 
        /// constructing the appropriate ImportInstance or ImportVolume request to Amazon EC2.
        /// </summary>
        /// <param name="credentials">
        /// The AWS credentials for the account that owns or has access to the bucket containing the manifest file.
        /// </param>
        /// <param name="region">The region in which the Amazon S3 client used for download will be constructed.</param>
        /// <param name="bucketName">The name of the bucket containing the manifest file.</param>
        /// <param name="manifestFileKey">The S3 object key of the manifest file.</param>
        /// <param name="resumingUpload">
        /// Set this to true if a previous upload failed part-way through processing and RetainArtifactsOnUploadError
        /// was set to true so the partially uploaded content was retained. The existing manifest will
        /// be inspected and uploads can then resume to process the retaining content.
        /// </param>
        /// <returns>Initialized importer instance containing a deserialized manifest</returns>
        public static DiskImageImporter FromManifest(AWSCredentials credentials, 
                                                     RegionEndpoint region, 
                                                     string bucketName, 
                                                     string manifestFileKey,
                                                     bool resumingUpload)
        {
            try
            {
                var importer = new DiskImageImporter(credentials, region, bucketName)
                {
                    ManifestFileKey = manifestFileKey
                };
                importer.DeserializeManifestFromS3();

                if (resumingUpload)
                    importer.DetermineRemainingUploads();

                return importer;
            }
            catch (AmazonS3Exception e)
            {
                var msg = string.Format(CultureInfo.InvariantCulture,
                                        "Failed to download the specified manifest from bucket {0} with key {1}",
                                        bucketName, 
                                        manifestFileKey);
                throw new DiskImageImporterException(DiskImportErrorStage.ManifestInspection, msg, e);
            }
            catch (XmlException e)
            {
                throw new DiskImageImporterException(DiskImportErrorStage.ManifestInspection, 
                                                     "Failed to deserialize the downloaded manifest", 
                                                     e);
            }
        }

        /// <summary>
        /// Initiates a conversion task to yield a new Amazon EC2 instance for a set of image file 
        /// artifacts uploaded previously to Amazon S3.
        /// </summary>
        /// <param name="launchConfiguration">Launch configuration settings for the imported instance</param>
        /// <returns>
        /// The service response containing a ConversionTask object that can be used to monitor the progress of the 
        /// requested conversion.
        /// </returns>
        public ImportInstanceResponse StartInstanceConversion(ImportLaunchConfiguration launchConfiguration)
        {
            if (string.IsNullOrEmpty(ManifestFileKey))
                throw new InvalidOperationException("No Amazon S3 object key available; have the image artifacts been uploaded?");

            var diskImage = PopulateDiskImage(ManifestFileKey, launchConfiguration.Description);
            var launchSpecification = PopulateLaunchSpecificationInstance(launchConfiguration);

            var request = new ImportInstanceRequest
            {
                Description = string.IsNullOrEmpty(launchConfiguration.Description) ? null : launchConfiguration.Description,
                LaunchSpecification = launchSpecification,
                Platform = string.IsNullOrEmpty(launchConfiguration.Platform) ? null : launchConfiguration.Platform
            };

            request.DiskImages.Add(diskImage);

            // allow any exception to propagate to the caller; this allows the calling tool to 
            // assist the user with re-executing the command by showing the appropriate command line
            // or remediation needed to avoid re-uploading the artifacts
            try
            {
                return EC2Client.ImportInstance(request);
            }
            catch (Exception e)
            {
                throw new DiskImageImporterException(DiskImportErrorStage.SendingImportRequest, e);
            }
        }

        /// <summary>
        /// Initiates a conversion task to yield a new EBS volume for a set of image file 
        /// artifacts uploaded previously to Amazon S3.
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone for the resulting Amazon EBS volume.</param>
        /// <param name="description">An optional description for the volume being imported.</param>
        /// <returns>
        /// The service response containing a ConversionTask object that can be used to monitor the progress of the 
        /// requested conversion.
        /// </returns>
        public ImportVolumeResponse StartVolumeConversion(string availabilityZone, string description)
        {
            if (string.IsNullOrEmpty(ManifestFileKey))
                throw new InvalidOperationException("No Amazon S3 object key available; have the image artifacts been uploaded?");

            var diskImageDetail = PopulateDiskImageDetail(ManifestFileKey);
            var volumeDetail = PopulateVolumeDetail();

            var request = new ImportVolumeRequest
            {
                AvailabilityZone = availabilityZone,
                Description = string.IsNullOrEmpty(description) ? null : description,
                Image = diskImageDetail,
                Volume = volumeDetail
            };

            // allow any exception to propagate to the caller; this allows the calling tool to 
            // assist the user with re-executing the command by showing the appropriate command line
            // or remediation needed to avoid re-uploading the artifacts
            return EC2Client.ImportVolume(request);
        }

        /// <summary>
        /// Helper to populate a DiskImageDetail instance from the SDK that will be used in an ImportVolume 
        /// API request using data previously recorded in the import manifest.
        /// </summary>
        /// <param name="manifestFileKey">The Amazon S3 object key of the manifest file.</param>
        /// <returns>Populated DiskImageDetail instance.</returns>
        public DiskImageDetail PopulateDiskImageDetail(string manifestFileKey)
        {
            return new DiskImageDetail
            {
                ImportManifestUrl = GetPresignedManifestUrl(manifestFileKey),
                Format = ImportManifest.FileFormat,
                Bytes = ImportManifest.ImportData.Size
            };
        }

        /// <summary>
        /// Helper to populate a DiskImage instance from the SDK that will be used in an ImportInstance 
        /// API request using data previously recorded in the import manifest.
        /// </summary>
        /// <param name="manifestFileKey">The Amazon S3 object key of the manifest file.</param>
        /// <param name="description">Optional description for the image.</param>
        /// <returns>Populated DiskImage instance.</returns>
        public DiskImage PopulateDiskImage(string manifestFileKey, string description)
        {
            if (ImportManifest == null)
                throw new InvalidOperationException("Expected import manifest to have been created prior to call.");

            var diskImageDetail = PopulateDiskImageDetail(manifestFileKey);
            var volumeDetail = PopulateVolumeDetail();

            return new DiskImage
            {
                Description = description,
                Image = diskImageDetail,
                Volume = volumeDetail
            };
        }

        /// <summary>
        /// Helper to populate a VolumeDetail instance from the SDK that will be used in an 
        /// ImportInstance or ImportVolume API request using data previously recorded in the 
        /// import manifest.
        /// </summary>
        /// <returns>Populated VolumeDetail instance.</returns>
        public VolumeDetail PopulateVolumeDetail()
        {
            return new VolumeDetail
            {
                Size = ImportManifest.ImportData.VolumeSize
            };
        }

        /// <summary>
        /// Helper to populate an SDK ImportInstanceLaunchSpecification instance that 
        /// will be used in an ImportInstance API request.
        /// </summary>
        /// <param name="config">Settings for the new LaunchSpecificationInstance</param>
        /// <returns>Populated ImportInstanceLaunchSpecification instance.</returns>
        public static ImportInstanceLaunchSpecification PopulateLaunchSpecificationInstance(ImportLaunchConfiguration config)
        {
            var launchSpecification = new ImportInstanceLaunchSpecification
            {
                Architecture = config.Architecture,
                InstanceType = config.InstanceType,
                Monitoring = config.EnableMonitoring,
            };

            if (config.SecurityGroupNames != null)
                launchSpecification.GroupNames.AddRange(config.SecurityGroupNames);

            if (!string.IsNullOrEmpty(config.AvailabilityZone))
                launchSpecification.Placement = new Placement { AvailabilityZone = config.AvailabilityZone };

            if (!string.IsNullOrEmpty(config.SubnetId))
                launchSpecification.SubnetId = config.SubnetId;

            if (!string.IsNullOrEmpty(config.PrivateIpAddress))
                launchSpecification.PrivateIpAddress = config.PrivateIpAddress;

            if (config.InstanceInitiatedShutdownBehavior != null)
                launchSpecification.InstanceInitiatedShutdownBehavior = config.InstanceInitiatedShutdownBehavior;

            if (!string.IsNullOrEmpty(config.AdditionalInfo))
                launchSpecification.AdditionalInfo = config.AdditionalInfo;

            return launchSpecification;
        }

        /// <summary>
        /// Downloads the manifest from Amazon S3 and deserializes the contents.
        /// </summary>
        void DeserializeManifestFromS3()
        {
            var response = S3Client.GetObject(new GetObjectRequest
            {
                BucketName = this.BucketName,
                Key = ManifestFileKey,
            });

            var serializer = new XmlSerializer(typeof(ImportManifestRoot));
            ImportManifest = (ImportManifestRoot)serializer.Deserialize(response.ResponseStream);
        }

        /// <summary>
        /// Analyzes the parts list of the manifest to determine which object parts exist
        /// in S3. Used when instantiating an importer from an existing manifest of a failed
        /// uploaded (RetainArtifactsOnUploadError set true to keep the partially uploaded content
        /// allowing uploads to be resumed part-way through).
        /// </summary>
        /// <remarks>
        /// Since the manifest contains a set of presigned urls to each part we can make use of those
        /// to determine whether a part has been uploaded or not. 
        /// </remarks>
        void DetermineRemainingUploads()
        {
            foreach (var part in ImportManifest.ImportData.PartsList.PartInstances)
            {
                try
                {
                    var request = WebRequest.Create(part.HeadUrl);
                    request.Method = "HEAD";
                    var response = request.GetResponse();
                    response.Close();
                    // if the HEAD request worked, log that the part can be skipped during resumption
                    part.UploadCompleted = true;
                }
                catch
                {
                    // always clear the state on exception so we'll retry parts we failed to HEAD 
                    // even if we thought we'd completed them successfully
                    part.UploadCompleted = false;
                }                
            }
        }

        /// <summary>
        /// Returns the maximum age, in days, to use for expiry for Amazon S3 presigned
        /// urls. For regions that require Signature Version 4 request signing, this is
        /// limited to 7 days.
        /// </summary>
        int UrlExpiryPeriod
        {
            get
            {
                if (Region != null && Region.GetEndpointForService("s3").SignatureVersionOverride == "4"
                            && UrlExpirationInDays > 7)
                    return 7;

                return UrlExpirationInDays;
            }
        }

        /// <summary>
        /// Constructs the presigned url to the import manifest in S3.
        /// </summary>
        /// <param name="manifestFileKey">The S3 object key of the manifest file.</param>
        /// <returns>Presigned url to the manifest file object.</returns>
        string GetPresignedManifestUrl(string manifestFileKey)
        {
            if (string.IsNullOrEmpty(_presignedManifestUrl))
                _presignedManifestUrl = S3Client.GetPreSignedURL(new GetPreSignedUrlRequest
                {
                    BucketName = BucketName,
                    Key = manifestFileKey,
                    Expires = DateTime.UtcNow.AddDays(UrlExpiryPeriod),
                    Verb = HttpVerb.GET
                });

            return _presignedManifestUrl;
        }

        /// <summary>
        /// Constructs the S3 object key for the manifest artifact. This will combine the root key, 
        /// any optional prefix the user has requested be applied and the filename of the artifact, 
        /// plus a fixed extension.
        /// </summary>
        /// <param name="imageFilepath">The path to the image file</param>
        void ConstructManifestArtifactKey(string imageFilepath)
        {
            if (string.IsNullOrEmpty(ManifestFileKey))

            ManifestFileKey = string.Format(CultureInfo.InvariantCulture,
                                            "{0}/{1}{2}",
                                            ArtifactsKeyPrefix,
                                            Path.GetFileName(imageFilepath),
                                            ManifestSuffix);
        }

        /// <summary>
        /// Serialize and upload the constructed import manifest using the supplied S3 client
        /// with optional progress callback.
        /// </summary>
        /// <param name="progressCallback">Optional callback to track upload progress.</param>
        void UploadManifest(ImportProgressCallback progressCallback = null)
        {
            if (string.IsNullOrEmpty(ManifestFileKey))
                throw new InvalidOperationException("Expected ManifestFileKey to have been constructed");

            using (var manifestStream = new MemoryStream())
            {
                if (progressCallback != null)
                    progressCallback("Creating import manifest...", null);

                // Get as close to the xml sent by the existing ec2 cli as possible, so no namespaces, 
                // Unix linefeeds and a standalone instruction, plus indentation of 4 spaces. This makes 
                // comparison of the two manifests easier if needed for debugging.
                var xmlContext = new XmlSerializer(typeof(ImportManifestRoot));
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add("", "");
                var writerCfg = new XmlWriterSettings
                {
                    Encoding = new UTF8Encoding(false),
                    NewLineChars = "\n",
                    NewLineHandling = NewLineHandling.Replace,
                    Indent = true,
                    IndentChars = "    "
                };
                using (var writer = XmlWriter.Create(manifestStream, writerCfg))
                {
                    writer.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"");
                    xmlContext.Serialize(writer, ImportManifest, namespaces);
                }

                if (progressCallback != null)
                    progressCallback("Creating and uploading import manifest...", null);

                var request = new PutObjectRequest
                {
                    BucketName = BucketName,
                    Key = ManifestFileKey,
                    InputStream = manifestStream,
                };

                // even though this is the first artifact to be uploaded and as such, if it fails,
                // there is nothing to clean up catch any exception so we can tell the user there
                // is no clean up required (for users concerned about storage costs).
                try
                {
                    S3Client.PutObject(request);
                }
                catch (Exception e)
                {
                    throw new DiskImageImporterException(DiskImportErrorStage.UploadingManifest,
                                                         "Upload of the image file manifest to Amazon S3 failed.\nThere are no orphaned objects requiring manual deletion.", 
                                                         e);
                }
            }
        }

        /// <summary>
        /// Uploads the image file to S3 as a series of distinct 10MB objects, as required by EC2,
        /// using the constructed import manifest as a guide. If any part fails to upload, we clean
        /// up successfully uploaded parts before returning the error to the caller.
        /// </summary>
        /// <param name="progressCallback">Optional callback to track upload progress.</param>
        void UploadImageParts(ImportProgressCallback progressCallback = null)
        {
            var imageFileinfo = new FileInfo(ImageFilePath);
            var partsList = ImportManifest.ImportData.PartsList;

            var activityMessage = string.Format(CultureInfo.InvariantCulture, 
                                                "Uploading image file ({0:N0} bytes across {1:N0} parts).", 
                                                imageFileinfo.Length, 
                                                partsList.Count);

            if (progressCallback != null)
                progressCallback(activityMessage, 0);

            // spin up the threads to handle the parts
            using (var fs = new FileStream(ImageFilePath, FileMode.Open, FileAccess.Read))
            {
                // CountdownEvent and CancellationToken would be ideal here but they
                // are not in .net 3.5
                var partUploadedEvent = new AutoResetEvent(false);

                for (var i = 0; i < UploadThreads; i++)
                {
                    var workerState = new ImagePartUploadState
                    {
                        S3Client = S3Client,
                        BucketName = BucketName,
                        PartsList = partsList,
                        ImageFileStream = fs,
                        PartProcessed = partUploadedEvent
                    };

                    ThreadPool.QueueUserWorkItem(UploadImageFilePart, workerState);
                }

                // Rather than rely on keeping a count of completed uploads to track progress, 
                // which could get out of sync if two threads fire the event at the same time, 
                // we scan and count progress on each event signal - that's been more reliable. 
                // Also, to allow for a loss of network connection we also have a timeout on 
                // the wait so we avoid any possibility of the event not being signalled due to 
                // the workers aborting without signalling.
                while (true)
                {
                    partUploadedEvent.WaitOne(5000);

                    if (partsList.HasFailedUploads)
                        break;

                    if (progressCallback != null)
                    {
                        var processedParts = partsList.PartInstances.Count(part => part.UploadCompleted);
                        progressCallback(activityMessage, (int)((double)processedParts / partsList.Count * 100));
                    }

                    if (_activeUploadWorkers == 0)
                        break;
                }
            }

            if (!partsList.HasFailedUploads)
            {
                if (progressCallback != null)
                    progressCallback("Image file upload completed.", null);
            }
            else
            {
                if (progressCallback != null)
                {
                    progressCallback("One or more image file parts failed to upload"
                        + (RollbackOnUploadError ? ", rolling back bucket content..." : string.Empty), null);
                }

                // wait until all of the workers are done before we start any possible clean up
                while (_activeUploadWorkers > 0)
                {
                    Thread.Sleep(500);
                }

                var msg = new StringBuilder("Upload of the image file artifacts to Amazon S3 failed.\r\n");
                if (RollbackOnUploadError)
                {
                    var allRemoved = RemoveUploadedArtifacts(ManifestFileKey, partsList.PartInstances);
                    if (allRemoved)
                        msg.Append("All content that had been uploaded has been successfully removed."
                                    + "\r\n"
                                    + "No further clean-up is required.\r\n");
                    else
                        msg.AppendFormat("Some content that had been uploaded could not be successfully removed."
                                        + "\r\n"
                                        + "Inspect the bucket content for objects with keyprefix"
                                        + "\r\n"
                                        + "'{0}'\r\nand delete them.\r\n",
                                         ArtifactsKeyPrefix);
                }
                else
                {
                    msg.Append("All content that had been uploaded successfully has been retained; the import can be resumed.\r\n");
                }

                throw new DiskImageImporterException(DiskImportErrorStage.UploadingImageFile, msg.ToString());
            }
        }

        /// <summary>
        /// Removes the manifest and iterates through the parts list to see which parts had been completed when 
        /// failures occur and removes those objects to avoid storage cost to the user (if the user retries the 
        /// command, a different root key guid will be generated leading to potential orphans).
        /// </summary>
        /// <param name="manifestFileKey">The object key of the manifest file.</param>
        /// <param name="partsList">The set of parts that should have been uploaded</param>
        /// <returns>True if all objects were successfully deleted, false if objects remain that the user should manually clean up</returns>
        bool RemoveUploadedArtifacts(string manifestFileKey, IEnumerable<ImageFilePart> partsList)
        {
            var allRemoved = true;

            try
            {
                S3Client.DeleteObject(new DeleteObjectRequest { BucketName = this.BucketName, Key = manifestFileKey });
            }
            catch (Exception)
            {
                allRemoved = false;
            }

            var keysToDelete = (from part in partsList where part.UploadCompleted select part.Key).ToList();

            var keyIndex = 0;
            while (keyIndex < keysToDelete.Count)
            {
                var request = new DeleteObjectsRequest {BucketName = this.BucketName};
                while (keyIndex < keysToDelete.Count && request.Objects.Count <= 1000)
                {
                    request.AddKey(keysToDelete[keyIndex++]);
                }

                try
                {
                    S3Client.DeleteObjects(request);
                }
                catch (Exception)
                {
                    allRemoved = false;
                }
            }

            return allRemoved;
        }

        /// <summary>
        /// Threadpool delegate to process image file parts one by one and upload to
        /// Amazon S3. If an error occurs, we abandon the part and continue to
        /// seek new ones (even though we won't process them, only signal). This
        /// allows all threads to exit before we attempt error clean up.
        /// </summary>
        /// <param name="state">ImagePartUploadState instance to process</param>
        static void UploadImageFilePart(object state)
        {
            Interlocked.Increment(ref _activeUploadWorkers);

            var uploadStateInfo = state as ImagePartUploadState;
            if (uploadStateInfo == null)
                throw new ArgumentException("Expected ImagePartUploadState instance to process");

            var buffer = new byte[DefaultPartSize];
            var part = uploadStateInfo.PartsList.FetchNextPartForUpload(uploadStateInfo.ImageFileStream, ref buffer);
            var uploadSucceeded = true;
            while (part != null && uploadSucceeded)
            {
                try
                {
                    if (!part.UploadCompleted) // if we're resuming, skip what was uploaded OK
                    {
                        using (var ms = new MemoryStream(buffer, 0, (int)part.ByteRange.Extent))
                        {
                            // implement an additional retry mode above and beyond what the
                            // SDKs standard http handling performs, to account for uploads
                            // on networks with considerable jitter
                            const int maxRetries = 5;
                            var attempt = 1;
                            while (!part.UploadCompleted && attempt <= maxRetries)
                            {
                                try
                                {
                                    var request = new PutObjectRequest
                                    {
                                        BucketName = uploadStateInfo.BucketName,
                                        Key = part.Key,
                                        InputStream = ms,
                                        AutoCloseStream = false
                                    };
                                    uploadStateInfo.S3Client.PutObject(request);
                                    part.UploadCompleted = true;
                                }
                                catch (Exception)
                                {
                                    attempt++;
                                }
                            }

                            if (!part.UploadCompleted)
                                throw new Exception("Failed to upload part " + part.Index + " after " + maxRetries +
                                                    " retries.");
                        }
                    }
                }
                catch (Exception)
                {
                    uploadSucceeded = false;
                    uploadStateInfo.PartsList.RegisterUploadFailure();
                }
                finally
                {
                    if (uploadSucceeded)
                    {
                        uploadStateInfo.PartProcessed.Set();
                        part = uploadStateInfo.PartsList.FetchNextPartForUpload(uploadStateInfo.ImageFileStream, ref buffer);
                    }
                }
            }

            Interlocked.Decrement(ref _activeUploadWorkers);
        }

        /// <summary>
        /// Constructs the object hierarchy that will be serialized to a single manifest
        /// file describing the import.
        /// </summary>
        /// <param name="fileFormat">
        /// The file format of the image file. If not specified, it will be inferred from the image 
        /// file extension. Valid values: VMDK | RAW | VHD. 
        /// </param>
        /// <param name="volumeSize">
        /// The requested size, in GiB, of the resulting volume in EC2. If not specified a suitable
        /// value will be used based on the size of the supplied image file.
        /// </param>
        /// <returns>Import manifest ready for serialization and upload.</returns>
        ImportManifestRoot CreateImportManifest(string fileFormat,
                                                long? volumeSize)
        {
            try
            {
                var urlExpiration = DateTime.UtcNow.AddDays(UrlExpiryPeriod);
                ConstructManifestArtifactKey(ImageFilePath);

                var format = fileFormat;
                if (string.IsNullOrEmpty(format))
                {
                    var ext = AWSSDKUtils.GetExtension(ImageFilePath);
                    if (string.IsNullOrEmpty(ext))
                        throw new ArgumentException("The image filename does not have an exception, so file format cannot be inferred.");

                    format = ext.TrimStart('.');
                }

                var manifest = new ImportManifestRoot
                {
                    Version = ManifestFileVersion,
                    FileFormat = format.ToUpper(CultureInfo.InvariantCulture), 
                    ImporterField = new ImporterInfo
                    {
                        Name = ManifestFileImporterName,
                        Version = ManifestFileImporterVersion,
                        Release = ManifestFileImporterRelease
                    },

                    SelfDestructUrl = S3Client.GetPreSignedURL(new GetPreSignedUrlRequest
                    {
                        BucketName = BucketName,
                        Key = ManifestFileKey,
                        Expires = urlExpiration,
                        Verb = HttpVerb.DELETE
                    }),

                    ImportData = ConstructImportPartsList(volumeSize, urlExpiration)
                };

                return manifest;
            }
            catch (Exception e)
            {
                throw new DiskImageImporterException(DiskImportErrorStage.GeneratingManifest, e);
            }
        }

        /// <summary>
        /// Walks the byte ranges of the image file to construct the logical parts we'll use to perform
        /// the upload
        /// </summary>
        /// <param name="volumeSize">The requested size of the volume in EC2</param>
        /// <param name="urlExpiration">The time at which the presigned urls for the parts should expire.</param>
        /// <returns>Manifest subcomponent describing the part structure.</returns>
        Import ConstructImportPartsList(long? volumeSize, DateTime urlExpiration)
        {
            var imageFilename = Path.GetFileName(ImageFilePath);
            var imageFileinfo = new FileInfo(ImageFilePath);
            var diskImageSize = imageFileinfo.Length;

            var partCount = (int)Math.Ceiling((double)diskImageSize / DefaultPartSize);

            var parts = new ImageFileParts { Count = partCount };
            var partKeyPrefix = string.Format(CultureInfo.InvariantCulture,
                                              "{0}/{1}.",
                                              ArtifactsKeyPrefix,
                                              imageFilename);

            long partStartOffset = 0;
            for (var i = 0; i < partCount; i++)
            {
                var partEndOffset = partStartOffset + DefaultPartSize - 1;
                if (partEndOffset >= diskImageSize)
                    partEndOffset = diskImageSize - 1;

                var partKey = string.Concat(partKeyPrefix, PartSuffix, i);
                var part = new ImageFilePart
                {
                    Index = i,
                    ByteRange = new ImageFilePartByteRange { Start = partStartOffset, End = partEndOffset },
                    Key = partKey,

                    HeadUrl = S3Client.GetPreSignedURL(new GetPreSignedUrlRequest
                    {
                        BucketName = BucketName,
                        Key = partKey,
                        Verb = HttpVerb.HEAD,
                        Expires = urlExpiration
                    }),

                    GetUrl = S3Client.GetPreSignedURL(new GetPreSignedUrlRequest
                    {
                        BucketName = BucketName,
                        Key = partKey,
                        Verb = HttpVerb.GET,
                        Expires = urlExpiration
                    }),

                    DeleteUrl = S3Client.GetPreSignedURL(new GetPreSignedUrlRequest
                    {
                        BucketName = BucketName,
                        Key = partKey,
                        Verb = HttpVerb.DELETE,
                        Expires = urlExpiration
                    })
                };
                parts.PartInstances.Add(part);

                partStartOffset += DefaultPartSize;
            }

            return new Import
            {
                Size = diskImageSize,
                VolumeSize = VolumeSizeFor(diskImageSize, volumeSize),
                PartsList = parts
            };
        }

        /// <summary>
        /// Computes the size of the volume to hold the image in EC2, with optional override
        /// by the user. Observation of the EC2 CLI shows a preferred minimum size for boot
        /// volumes of 8GB.
        /// </summary>
        /// <param name="diskImageSize">The size of the image we're processing, in bytes</param>
        /// <param name="requestedSize">Optional size requested by the user</param>
        static long VolumeSizeFor(long diskImageSize, long? requestedSize)
        {
            if (requestedSize.HasValue && requestedSize.Value > 0)
                return requestedSize.Value;

            var volumeSize = diskImageSize;
            if (volumeSize < 8*OneGb)
                volumeSize = 8*OneGb;

            return (long)Math.Ceiling((double)volumeSize / (double)OneGb);
        }
    }

    #region Manifest Serialization/Artifact Upload

    /// <summary>
    /// <para>
    /// Serialization class for processing the import and conversion of a virtual machine image to 
    /// a new Amazon EC2 instance, or a disk image to a new EBS volume.
    /// </para>
    /// <para>
    /// This class represents the root of the data contained in the conversion manifest.
    /// </para>
    /// </summary>
    [XmlType("manifest")]
    public class ImportManifestRoot
    {
        [XmlElement("version")]
        public String Version { get; set; }

        [XmlElement("file-format")]
        public string FileFormat { get; set; }

        [XmlElement("importer")]
        public ImporterInfo ImporterField { get; set; }

        [XmlElement("self-destruct-url")]
        public string SelfDestructUrl { get; set; }

        [XmlElement("import")]
        public Import ImportData { get; set; }
    }

    /// <summary>
    /// <para>
    /// Serialization class for processing the import and conversion of a virtual machine image to 
    /// a new Amazon EC2 instance, or a disk image to a new EBS volume.
    /// </para>
    /// <para>
    /// This class represents version and requester metadata for the conversion.
    /// </para>
    /// </summary>
    [XmlType("importer")]
    public class ImporterInfo
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("version")]
        public string Version { get; set; }

        [XmlElement("release")]
        public string Release { get; set; }
    }

    /// <summary>
    /// <para>
    /// Serialization class for processing the import and conversion of a virtual machine image to 
    /// a new Amazon EC2 instance, or a disk image to a new EBS volume.
    /// </para>
    /// <para>
    /// This class represents the root of the data describing the data slices of the image file that are
    /// to be uploaded to Amazon S3 and the requested size of the volume to hold the data after conversion.
    /// </para>
    /// </summary>
    public class Import
    {
        [XmlElement("size")]
        public long Size { get; set; }

        [XmlElement("volume-size")]
        public long VolumeSize { get; set; }

        [XmlElement("parts")]
        public ImageFileParts PartsList { get; set; }
    }

    /// <summary>
    /// <para>
    /// Serialization class for processing the import and conversion of a virtual machine image to 
    /// a new Amazon EC2 instance, or a disk image to a new EBS volume.
    /// </para>
    /// <para>
    /// This class represents the list of 'slices' of the image file that is to be uploaded to 
    /// Amazon S3, together with helper to return the next slice for processing during the upload
    /// process.
    /// </para>
    /// </summary>
    [XmlType("parts")]
    public class ImageFileParts
    {
        /// <summary>
        /// The collection of parts making up the image.
        /// </summary>
        [XmlElement(ElementName = "part")]
        public List<ImageFilePart> PartInstances { get; set; }

        /// <summary>
        /// The number of parts in the image.
        /// </summary>
        [XmlAttribute("count")]
        public int Count { get; set; }

        /// <summary>
        /// Initializes an empty collection of parts
        /// </summary>
        public ImageFileParts()
        {
            PartInstances = new List<ImageFilePart>();
        }

        /// <summary>
        /// Returns the next part to be uploaded, with its data loaded into the
        /// supplied buffer.
        /// </summary>
        /// <remarks>
        /// We want to serialize read access to the image file stream so that we do not
        /// 'thrash' or encounter problems with a non-seekable stream, but at the same
        /// time parallelize the part uploads. Reading the data prior to returning the
        /// part instance data satisfies this requirement.
        /// </remarks>
        /// <param name="imageFileStream">The stream wrapping the image file.</param>
        /// <param name="buffer">Buffer into which the part data will be read.</param>
        /// <returns>
        /// The part to upload or null if the image file has now been consumed.
        /// </returns>
        /// <remarks>
        /// If an error occurs during a part upload, we currently cease yielding parts 
        /// to all workers, causing them to expire cleanly 'asap'. This strategy allows 
        /// us to change to a 'greedy' approach in future where we simply skip over the 
        /// part in error and do as much uploading as we can before exit.
        /// </remarks>
        internal ImageFilePart FetchNextPartForUpload(Stream imageFileStream, ref byte[] buffer)
        {
            ImageFilePart nextPart = null;
            try
            {
                lock (_syncLock)
                {
                    if (_failedUploads > 0)  // ensures all workers quit asap
                        return null;

                    if (_nextPartForUpload < PartInstances.Count)
                    {
                        nextPart = PartInstances[_nextPartForUpload];
                        imageFileStream.Read(buffer, 0, (int)nextPart.ByteRange.Extent);
                        _nextPartForUpload++;
                    }
                }
            }
            catch
            {
                Interlocked.Increment(ref _failedUploads);
            }
            return nextPart;
        }

        /// <summary>
        /// Allows the upload threadpool workers to register that one or
        /// more parts failed to upload successfully.
        /// </summary>
        internal void RegisterUploadFailure()
        {
            Interlocked.Increment(ref _failedUploads);
        }

        /// <summary>
        /// True if any image file part failed to upload successfully.
        /// </summary>
        internal bool HasFailedUploads 
        {
            get
            {
                var ret = false;
                lock (_syncLock)
                {
                    ret = _failedUploads > 0;
                }
                return ret;
            }    
        }

        private readonly object _syncLock = new object();
        private int _nextPartForUpload;
        private int _failedUploads;
    }

    /// <summary>
    /// <para>
    /// Serialization class for processing the import and conversion of a virtual machine image to 
    /// a new Amazon EC2 instance, or a disk image to a new EBS volume.
    /// </para>
    /// <para>
    /// This class represents a single 'slice' of the image file that is to be uploaded to 
    /// Amazon S3.
    /// </para>
    /// </summary>
    [XmlType("part")]
    public class ImageFilePart
    {
        /// <summary>
        /// The range of bytes representing the part.
        /// </summary>
        [XmlElement("byte-range")]
        public ImageFilePartByteRange ByteRange { get; set; }

        /// <summary>
        /// The Amazon S3 object key of the part.
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        [XmlElement("head-url")]
        public string HeadUrl { get; set; }

        [XmlElement("get-url")]
        public string GetUrl { get; set; }

        [XmlElement("delete-url")]
        public string DeleteUrl { get; set; }

        /// <summary>
        /// The sequence number of the part within the whole image.
        /// </summary>
        [XmlAttribute(AttributeName = "index")]
        public int Index { get; set; }

        /// <summary>
        /// Indicates whether the part upload completed successfully.
        /// </summary>
        internal bool UploadCompleted { get; set; }
    }

    /// <summary>
    /// <para>
    /// Serialization class for processing the import and conversion of a virtual machine image to 
    /// a new Amazon EC2 instance, or a disk image to a new EBS volume.
    /// </para>
    /// <para>
    /// This class represents the offset and extent of a single 'slice' of the image file that is to 
    /// be uploaded to Amazon S3.
    /// </para>
    /// </summary>
    public class ImageFilePartByteRange
    {
        /// <summary>
        /// The byte offset indicating the end of the range.
        /// </summary>
        [XmlAttribute("end")]
        public long End { get; set; }

        /// <summary>
        /// The byte offset indicating the start of the range.
        /// </summary>
        [XmlAttribute("start")]
        public long Start { get; set; }

        /// <summary>
        /// The length of the byte range.
        /// </summary>
        [XmlIgnore]
        public long Extent { get { return End - Start + 1; } }
    }

    #endregion

    /// <summary>
    /// State class used to pass data about the image part to be processed to the
    /// thread pool worker.
    /// </summary>
    internal class ImagePartUploadState
    {
        public IAmazonS3 S3Client { get; set; }
        public string BucketName { get; set; }
        public ImageFileParts PartsList { get; set; }
        public Stream ImageFileStream { get; set; }
        public AutoResetEvent PartProcessed { get; set; }
    }

    public enum DiskImportErrorStage
    {
        /// <summary>
        /// Error was detected during construction of the import
        /// manifest/analysis of the image file
        /// </summary>
        GeneratingManifest,

        /// <summary>
        /// Error was detected during download/deserialization of
        /// a previously uploaded manifest
        /// </summary>
        ManifestInspection,

        /// <summary>
        /// Error was detected during upload of the import manifest
        /// to S3
        /// </summary>
        UploadingManifest,

        /// <summary>
        /// Error was detected during upload of the part artifacts making
        /// up the image file
        /// </summary>
        UploadingImageFile,

        /// <summary>
        /// Error was detected during the sending of the request to EC2
        /// to start conversion of the uploaded image file
        /// </summary>
        SendingImportRequest
    }

    /// <summary>
    /// Wraps errors returned from the importer
    /// </summary>
    public class DiskImageImporterException : Exception
    {
        /// <summary>
        /// What stage the importer was at when the error occurred
        /// </summary>
        public DiskImportErrorStage Stage { get; private set; }

        internal DiskImageImporterException(DiskImportErrorStage stage, string message, Exception innerException)
            : base(message, innerException)
        {
            Stage = stage;
        }

        internal DiskImageImporterException(DiskImportErrorStage stage, string message)
            : this(stage, message, null)
        {
        }

        internal DiskImageImporterException(DiskImportErrorStage stage, Exception innerException)
            : this(stage, string.Empty, innerException)
        {
        }
    }

    /// <summary>
    /// Settings configuring the EC2 instance launch phase after an image file has been 
    /// uploaded.
    /// </summary>
    public class ImportLaunchConfiguration
    {
        /// <summary>
        /// The Amazon EC2 instance type to launch for the conversion
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// The instance operating system. Valid values: Windows | Linux
        /// </summary>
        public PlatformValues Platform { get; set; }

        /// <summary>
        /// The architecture of the instance. Valid values: i386 | x86_64
        /// </summary>
        public ArchitectureValues Architecture { get; set; }

        /// <summary>
        /// Optional description for the instance being imported.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Optional availability zone to launch the instance into. If not specified one will be chosen for you
        /// by EC2.
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// One or more security group names. This is not supported for VMs imported into a VPC, which are 
        /// assigned the default security group. After a VM is imported into a VPC, you can change the instance 
        /// to use another security group.
        /// </summary>
        public ICollection<string> SecurityGroupNames { get; set; }

        /// <summary>
        /// [EC2-VPC] Optionally, you can use this parameter to assign the instance a specific available IP address 
        /// from the IP address range of the subnet.
        /// </summary>
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// [EC2-VPC] The ID of the subnet to launch the instance into.
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Indicates whether to enable detailed monitoring for the instance.
        /// </summary>
        public bool EnableMonitoring { get; set; }

        /// <summary>
        /// Indicates whether an instance stops or terminates when you initiate shutdown from the instance (using 
        /// the operating system command for system shutdown). Valid values: stop | terminate. 
        /// </summary>
        public ShutdownBehavior InstanceInitiatedShutdownBehavior { get; set; }

        /// <summary>
        /// Reserved for internal use.
        /// </summary>
        public string AdditionalInfo { get; set; }
    }
#endif
}
