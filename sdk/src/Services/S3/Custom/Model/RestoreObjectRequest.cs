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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreObject operation.
    /// <para>Restores an archived copy of an object back into Amazon S3</para>
    /// </summary>
    public partial class RestoreObjectRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private string key;
        private int? days;
        private string versionId;
		private RequestPayer requestPayer;
		private GlacierJobTier tier;
        private GlacierJobTier retrievalTier;

        private RestoreRequestType type;
        private string description;
        private SelectParameters selectParameters;
        private OutputLocation outputLocation;
        private string expectedBucketOwner;

        /// <summary>
        /// <para>The bucket name containing the object to restore. </para> 
        /// <para>When using this API with an access point, you must direct requests to 
        /// the access point hostname. The access point hostname takes the 
        /// form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. 
        /// When using this operation with an access point through the AWS SDKs, 
        /// you provide the access point ARN in place of the bucket name.
        /// For more information about access point ARNs, 
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html\">
        /// Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</para> 
        /// <p>When using this API with Amazon S3 on Outposts, you must direct requests to the 
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form 
        /// <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com. 
        /// When using this operation using S3 on Outposts through the AWS SDKs, 
        /// you provide the Outposts bucket ARN in place of the bucket name. 
        /// For more information about S3 on Outposts ARNs, 
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3onOutposts.html\">Using S3 on 
        /// Outposts</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</p>
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
        /// VersionId used to reference a specific version of the object.
        ///  
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

		/// <summary>
        /// Confirms that the requester knows that she or he will be charged for the list objects request.
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
            xmlWriter.WriteStartElement(propertyName);
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
        /// The account id of the expected bucket owner. 
        /// If the bucket is owned by a different account, the request will fail with an HTTP 403 (Access Denied) error.
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
    }
}
    
