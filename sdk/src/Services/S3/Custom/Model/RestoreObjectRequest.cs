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
using System;
using System.Xml;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreObject operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Restores an archived copy of an object back into Amazon S3
    /// </para>
    ///  
    /// <para>
    /// This functionality is not supported for Amazon S3 on Outposts.
    /// </para>
    ///  
    /// <para>
    /// This action performs the following types of requests: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>restore an archive</c> - Restore an archived object
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about the <c>S3</c> structure in the request body, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Managing
    /// Access with ACLs</a> in the <i>Amazon S3 User Guide</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
    /// Data Using Server-Side Encryption</a> in the <i>Amazon S3 User Guide</i> 
    /// </para>
    ///  </li> </ul> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// To use this operation, you must have permissions to perform the <c>s3:RestoreObject</c>
    /// action. The bucket owner has this permission by default and can grant this permission
    /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> <dt>Restoring objects</dt> <dd> 
    /// <para>
    /// Objects that you archive to the S3 Glacier Flexible Retrieval Flexible Retrieval or
    /// S3 Glacier Deep Archive storage class, and S3 Intelligent-Tiering Archive or S3 Intelligent-Tiering
    /// Deep Archive tiers, are not accessible in real time. For objects in the S3 Glacier
    /// Flexible Retrieval Flexible Retrieval or S3 Glacier Deep Archive storage classes,
    /// you must first initiate a restore request, and then wait until a temporary copy of
    /// the object is available. If you want a permanent copy of the object, create a copy
    /// of it in the Amazon S3 Standard storage class in your S3 bucket. To access an archived
    /// object, you must restore the object for the duration (number of days) that you specify.
    /// For objects in the Archive Access or Deep Archive Access tiers of S3 Intelligent-Tiering,
    /// you must first initiate a restore request, and then wait until the object is moved
    /// into the Frequent Access tier.
    /// </para>
    ///  
    /// <para>
    /// To restore a specific object version, you can provide a version ID. If you don't provide
    /// a version ID, Amazon S3 restores the current version.
    /// </para>
    ///  
    /// <para>
    /// When restoring an archived object, you can specify one of the following data access
    /// tier options in the <c>Tier</c> element of the request body: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Expedited</c> - Expedited retrievals allow you to quickly access your data stored
    /// in the S3 Glacier Flexible Retrieval Flexible Retrieval storage class or S3 Intelligent-Tiering
    /// Archive tier when occasional urgent requests for restoring archives are required.
    /// For all but the largest archived objects (250 MB+), data accessed using Expedited
    /// retrievals is typically made available within 1–5 minutes. Provisioned capacity ensures
    /// that retrieval capacity for Expedited retrievals is available when you need it. Expedited
    /// retrievals and provisioned capacity are not available for objects stored in the S3
    /// Glacier Deep Archive storage class or S3 Intelligent-Tiering Deep Archive tier.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Standard</c> - Standard retrievals allow you to access any of your archived objects
    /// within several hours. This is the default option for retrieval requests that do not
    /// specify the retrieval option. Standard retrievals typically finish within 3–5 hours
    /// for objects stored in the S3 Glacier Flexible Retrieval Flexible Retrieval storage
    /// class or S3 Intelligent-Tiering Archive tier. They typically finish within 12 hours
    /// for objects stored in the S3 Glacier Deep Archive storage class or S3 Intelligent-Tiering
    /// Deep Archive tier. Standard retrievals are free for objects stored in S3 Intelligent-Tiering.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Bulk</c> - Bulk retrievals free for objects stored in the S3 Glacier Flexible
    /// Retrieval and S3 Intelligent-Tiering storage classes, enabling you to retrieve large
    /// amounts, even petabytes, of data at no cost. Bulk retrievals typically finish within
    /// 5–12 hours for objects stored in the S3 Glacier Flexible Retrieval Flexible Retrieval
    /// storage class or S3 Intelligent-Tiering Archive tier. Bulk retrievals are also the
    /// lowest-cost retrieval option when restoring objects from S3 Glacier Deep Archive.
    /// They typically finish within 48 hours for objects stored in the S3 Glacier Deep Archive
    /// storage class or S3 Intelligent-Tiering Deep Archive tier. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about archive retrieval options and provisioned capacity for
    /// <c>Expedited</c> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
    /// Archived Objects</a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// You can use Amazon S3 restore speed upgrade to change the restore speed to a faster
    /// speed while it is in progress. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html#restoring-objects-upgrade-tier.title.html">
    /// Upgrading the speed of an in-progress restore</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// To get the status of object restoration, you can send a <c>HEAD</c> request. Operations
    /// return the <c>x-amz-restore</c> header, which provides information about the restoration
    /// status, in the response. You can use Amazon S3 event notifications to notify you when
    /// a restore is initiated or completed. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
    /// Amazon S3 Event Notifications</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// After restoring an archived object, you can update the restoration period by reissuing
    /// the request with a new period. Amazon S3 updates the restoration period relative to
    /// the current time and charges only for the request-there are no data transfer charges.
    /// You cannot update the restoration period when Amazon S3 is actively processing your
    /// current restore request for the object.
    /// </para>
    ///  
    /// <para>
    /// If your bucket has a lifecycle configuration with a rule that includes an expiration
    /// action, the object expiration overrides the life span that you specify in a restore
    /// request. For example, if you restore an object copy for 10 days, but the object is
    /// scheduled to expire in 3 days, Amazon S3 deletes the object in 3 days. For more information
    /// about lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
    /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
    /// Lifecycle Management</a> in <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> <dt>Responses</dt> <dd> 
    /// <para>
    /// A successful action returns either the <c>200 OK</c> or <c>202 Accepted</c> status
    /// code. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the object is not previously restored, then Amazon S3 returns <c>202 Accepted</c>
    /// in the response. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the object is previously restored, Amazon S3 returns <c>200 OK</c> in the response.
    /// 
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Special errors:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Code: RestoreAlreadyInProgress</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: Object restore is already in progress.</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>HTTP Status Code: 409 Conflict</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>SOAP Fault Code Prefix: Client</i> 
    /// </para>
    ///  </li> </ul> </li> <li> <ul> <li> 
    /// <para>
    ///  <i>Code: GlacierExpeditedRetrievalNotAvailable</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: expedited retrievals are currently not available. Try again later. (Returned
    /// if there is insufficient capacity to process the Expedited request. This error applies
    /// only to Expedited retrievals and not to S3 Standard or Bulk retrievals.)</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>HTTP Status Code: 503</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>SOAP Fault Code Prefix: N/A</i> 
    /// </para>
    ///  </li> </ul> </li> </ul> </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>RestoreObject</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutBucketLifecycleConfiguration.html">PutBucketLifecycleConfiguration</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketNotificationConfiguration.html">GetBucketNotificationConfiguration</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RestoreObjectRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private int? days;
        private string expectedBucketOwner;
        private string description;
        private string key;
        private GlacierJobTier tier;
        private GlacierJobTier retrievalTier;
        private RestoreRequestType type;
        private SelectParameters selectParameters;
        private OutputLocation outputLocation;
        private RequestPayer requestPayer;
        private string versionId;
        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name containing the object to restore. 
        /// </para> 
        /// <para> 
        /// <b>Access points</b> - When you use this action with an access point for general purpose buckets, you must 
        /// provide the alias of the access point in place of the bucket name or specify the access point ARN. When you 
        /// use this action with an access point for directory buckets, you must provide the access point name in place 
        /// of the bucket name. When using the access point ARN, you must direct requests to the access point hostname. The 
        /// access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When 
        /// using this action with an access point through the Amazon Web Services SDKs, you provide the access point 
        /// ARN in place of the bucket name. For more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using access points</a> in 
        /// the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <para> 
        /// <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must direct requests to the S3 on Outposts 
        /// hostname. The S3 on Outposts hostname takes the form <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>. When 
        /// you use this action with S3 on Outposts, the destination bucket must be the Outposts access point ARN or the access 
        /// point alias. For more information about S3 on Outposts, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What is S3 on Outposts?</a> in 
        /// the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum</c>
        /// or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the request
        /// with the HTTP status code <c>400 Bad Request</c>. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <c>ChecksumAlgorithm</c>
        /// parameter.
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// <para>Lifetime of the active copy in days. 
        /// Do not use with restores that specify <c>OutputLocation</c>.</para> 
        /// <para>The Days element is required for regular restores, and must not be provided for 
        /// select requests.</para>
        /// </summary>
        public int? Days
        {
            get { return this.days; }
            set { this.days = value; }
        }

        // Check to see if Days property is set
        internal bool IsSetDays()
        {
            return this.days.HasValue;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

        /// <summary>
        /// The optional description for the job.
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// Gets and sets the Key property. This key indicates the S3 object to restore.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". 
        /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory.
        /// </para>
        /// <para>
        /// Starting with .NET 8, the AWS .NET SDK disables System.Uri's feature of canonicalizing the resource path. This allows S3 keys like
        /// "foo/../bar/file.txt" to work correctly with the AWS .NET SDK.
        /// </para>
        /// <para>
        /// For further information view the documentation for the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </para>
        /// </remarks>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// <para>Tier at which the restore will be processed.</para>
        /// </summary>
        public GlacierJobTier Tier
        {
            get { return this.tier; }
            set { this.tier = value; }
        }
        
        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this.tier != null;
        }

        /// <summary>
        /// <para>Retrieval tier at which the restore will be processed.</para>
        /// </summary>
        public GlacierJobTier RetrievalTier
        {
            get { return this.retrievalTier; }
            set { this.retrievalTier = value; }
        }

        internal bool IsSetRetrievalTier()
        {
            return this.retrievalTier != null;
        }

        /// <summary>
        /// Type of restore request.
        /// </summary>
        public RestoreRequestType RestoreRequestType
        {
            get { return this.type; }
            set { this.type = value; }
        }

        internal bool IsSetType()
        {
            return this.type != null;
        }
        
        /// <summary>
        /// Describes the parameters for Select job types.
        /// </summary>
        public SelectParameters SelectParameters
        {
            get { return this.selectParameters; }
            set { this.selectParameters = value; }
        }

        internal bool IsSetSelectParameters()
        {
            return this.selectParameters != null;
        }

        /// <summary>
        /// Describes the location where the restore job's output is stored.
        /// </summary>
        public OutputLocation OutputLocation
        {
            get { return this.outputLocation; }
            set { this.outputLocation = value; }
        }

        internal bool IsSetOutputLocation()
        {
            return this.outputLocation != null;
        }

        internal void Marshall(string propertyName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(propertyName, S3Constants.S3RequestXmlNamespace);
            {
                if (IsSetRetrievalTier())
                    xmlWriter.WriteElementString("Tier", S3Transforms.ToXmlStringValue(RetrievalTier));

                if (IsSetTier())
                {
                    xmlWriter.WriteStartElement("GlacierJobParameters");
                    {
                        xmlWriter.WriteElementString("Tier", S3Transforms.ToXmlStringValue(Tier));
                    }
                    xmlWriter.WriteEndElement();
                }

                if (IsSetDays())
                    xmlWriter.WriteElementString("Days", S3Transforms.ToXmlStringValue(Days.Value));
                if (IsSetType())
                    xmlWriter.WriteElementString("Type", S3Transforms.ToXmlStringValue(RestoreRequestType.Value));
                if (IsSetDescription())
                    xmlWriter.WriteElementString("Description", S3Transforms.ToXmlStringValue(Description));
                if (IsSetSelectParameters())
                    SelectParameters.Marshall("SelectParameters", xmlWriter);
                if (IsSetOutputLocation())
                    OutputLocation.Marshall("OutputLocation", xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }

        /// <summary>
        /// Confirms that the requester knows that she or he will be charged for the request.
        /// Bucket owners need not specify this parameter in their requests.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }
        
        /// <summary>
        /// Checks to see if RequetsPayer is set.
        /// </summary>
        /// <returns>true, if RequestPayer property is set.</returns>
        internal bool IsSetRequestPayer()
        {
            return requestPayer != null;
        }

        /// <summary>
        /// VersionId used to reference a specific version of the object.
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this.versionId != null;
        }
    }
}
    
