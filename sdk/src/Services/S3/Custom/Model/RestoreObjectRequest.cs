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
    /// Restores an archived copy of an object back into Amazon S3
    /// 
    ///  
    /// <para>
    /// This action is not supported by Amazon S3 on Outposts.
    /// </para>
    ///  
    /// <para>
    /// This action performs the following types of requests: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>select</code> - Perform a select query on an archived object
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>restore an archive</code> - Restore an archived object
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To use this operation, you must have permissions to perform the <code>s3:RestoreObject</code>
    /// action. The bucket owner has this permission by default and can grant this permission
    /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Querying Archives with Select Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// You use a select type of request to perform SQL queries on archived objects. The archived
    /// objects that are being queried by the select request must be formatted as uncompressed
    /// comma-separated values (CSV) files. You can run queries and custom analytics on your
    /// archived data without having to restore your data to a hotter Amazon S3 tier. For
    /// an overview about select requests, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
    /// Archived Objects</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When making a select request, do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Define an output location for the select query's output. This must be an Amazon S3
    /// bucket in the same Amazon Web Services Region as the bucket that contains the archive
    /// object that is being queried. The Amazon Web Services account that initiates the job
    /// must have permissions to write to the S3 bucket. You can specify the storage class
    /// and encryption for the output objects stored in the bucket. For more information about
    /// output, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
    /// Archived Objects</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about the <code>S3</code> structure in the request body, see
    /// the following:
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
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Define the SQL expression for the <code>SELECT</code> type of restoration for your
    /// query in the request body's <code>SelectParameters</code> structure. You can use expressions
    /// like the following examples.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The following expression returns all records from the specified object.
    /// </para>
    ///  
    /// <para>
    ///  <code>SELECT * FROM Object</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Assuming that you are not using any headers for data stored in the object, you can
    /// specify columns with positional headers.
    /// </para>
    ///  
    /// <para>
    ///  <code>SELECT s._1, s._2 FROM Object s WHERE s._3 &gt; 100</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you have headers and you set the <code>fileHeaderInfo</code> in the <code>CSV</code>
    /// structure in the request body to <code>USE</code>, you can specify headers in the
    /// query. (If you set the <code>fileHeaderInfo</code> field to <code>IGNORE</code>, the
    /// first row is skipped for the query.) You cannot mix ordinal positions with header
    /// column names. 
    /// </para>
    ///  
    /// <para>
    ///  <code>SELECT s.Id, s.FirstName, s.SSN FROM S3Object s</code> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// For more information about using SQL with S3 Glacier Select restore, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
    /// Reference for Amazon S3 Select and S3 Glacier Select</a> in the <i>Amazon S3 User
    /// Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// When making a select request, you can also do the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To expedite your queries, specify the <code>Expedited</code> tier. For more information
    /// about tiers, see "Restoring Archives," later in this topic.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify details about the data serialization format of both the input object that
    /// is being queried and the serialization of the CSV-encoded query results.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following are additional important facts about the select feature:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The output results are new Amazon S3 objects. Unlike archive retrievals, they are
    /// stored until explicitly deleted-manually or through a lifecycle policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can issue more than one select request on the same Amazon S3 object. Amazon S3
    /// doesn't deduplicate requests, so avoid issuing duplicate requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Amazon S3 accepts a select request even if the object has already been restored.
    /// A select request doesn’t return error response <code>409</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Restoring objects</b> 
    /// </para>
    ///  
    /// <para>
    /// Objects that you archive to the S3 Glacier or S3 Glacier Deep Archive storage class,
    /// and S3 Intelligent-Tiering Archive or S3 Intelligent-Tiering Deep Archive tiers are
    /// not accessible in real time. For objects in Archive Access or Deep Archive Access
    /// tiers you must first initiate a restore request, and then wait until the object is
    /// moved into the Frequent Access tier. For objects in S3 Glacier or S3 Glacier Deep
    /// Archive storage classes you must first initiate a restore request, and then wait until
    /// a temporary copy of the object is available. To access an archived object, you must
    /// restore the object for the duration (number of days) that you specify.
    /// </para>
    ///  
    /// <para>
    /// To restore a specific object version, you can provide a version ID. If you don't provide
    /// a version ID, Amazon S3 restores the current version.
    /// </para>
    ///  
    /// <para>
    /// When restoring an archived object (or using a select request), you can specify one
    /// of the following data access tier options in the <code>Tier</code> element of the
    /// request body: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b> <code>Expedited</code> </b> - Expedited retrievals allow you to quickly access
    /// your data stored in the S3 Glacier storage class or S3 Intelligent-Tiering Archive
    /// tier when occasional urgent requests for a subset of archives are required. For all
    /// but the largest archived objects (250 MB+), data accessed using Expedited retrievals
    /// is typically made available within 1–5 minutes. Provisioned capacity ensures that
    /// retrieval capacity for Expedited retrievals is available when you need it. Expedited
    /// retrievals and provisioned capacity are not available for objects stored in the S3
    /// Glacier Deep Archive storage class or S3 Intelligent-Tiering Deep Archive tier.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <code>Standard</code> </b> - Standard retrievals allow you to access any of your
    /// archived objects within several hours. This is the default option for retrieval requests
    /// that do not specify the retrieval option. Standard retrievals typically finish within
    /// 3–5 hours for objects stored in the S3 Glacier storage class or S3 Intelligent-Tiering
    /// Archive tier. They typically finish within 12 hours for objects stored in the S3 Glacier
    /// Deep Archive storage class or S3 Intelligent-Tiering Deep Archive tier. Standard retrievals
    /// are free for objects stored in S3 Intelligent-Tiering.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <code>Bulk</code> </b> - Bulk retrievals are the lowest-cost retrieval option
    /// in S3 Glacier, enabling you to retrieve large amounts, even petabytes, of data inexpensively.
    /// Bulk retrievals typically finish within 5–12 hours for objects stored in the S3 Glacier
    /// storage class or S3 Intelligent-Tiering Archive tier. They typically finish within
    /// 48 hours for objects stored in the S3 Glacier Deep Archive storage class or S3 Intelligent-Tiering
    /// Deep Archive tier. Bulk retrievals are free for objects stored in S3 Intelligent-Tiering.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about archive retrieval options and provisioned capacity for
    /// <code>Expedited</code> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
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
    /// To get the status of object restoration, you can send a <code>HEAD</code> request.
    /// Operations return the <code>x-amz-restore</code> header, which provides information
    /// about the restoration status, in the response. You can use Amazon S3 event notifications
    /// to notify you when a restore is initiated or completed. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
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
    ///  
    /// <para>
    ///  <b>Responses</b> 
    /// </para>
    ///  
    /// <para>
    /// A successful action returns either the <code>200 OK</code> or <code>202 Accepted</code>
    /// status code. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the object is not previously restored, then Amazon S3 returns <code>202 Accepted</code>
    /// in the response. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the object is previously restored, Amazon S3 returns <code>200 OK</code> in the
    /// response. 
    /// </para>
    ///  </li> </ul> <para class="title"> <b>Special Errors</b> 
    /// </para>
    ///  <ul> <li> <ul> <li> 
    /// <para>
    ///  <i>Code: RestoreAlreadyInProgress</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Cause: Object restore is already in progress. (This error does not apply to SELECT
    /// type requests.)</i> 
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
    ///  </li> </ul> </li> </ul> <para class="title"> <b>Related Resources</b> 
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
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
    /// Reference for Amazon S3 Select and S3 Glacier Select </a> in the <i>Amazon S3 User
    /// Guide</i> 
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
        ///  
        /// <para>
        /// When using this action with an access point, you must direct requests to the access
        /// point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you use this action with Amazon S3 on Outposts, you must direct requests to the
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts access point ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Indicates the algorithm used to create the checksum for the object. Amazon S3 will
        /// fail the request with a 400 error if there is no checksum associated with the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Do not use with restores that specify <code>OutputLocation</code>.</para> 
        /// <para>The Days element is required for regular restores, and must not be provided for 
        /// select requests.</para>
        /// </summary>
        public int Days
        {
            get { return this.days ?? default(int); }
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
        /// The account ID of the expected bucket owner. If the bucket is owned by a different
        /// account, the request will fail with an HTTP <code>403 (Access Denied)</code> error.
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
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
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
                    xmlWriter.WriteElementString("Days", S3Transforms.ToXmlStringValue(Days));
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
    
