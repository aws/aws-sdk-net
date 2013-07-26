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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// <para> Output structure for the GetStatus operation. </para>
    /// </summary>
    public partial class GetStatusResult : AmazonWebServiceResponse
    {
        
        private string jobId;
        private JobType jobType;
        private string awsShippingAddress;
        private string locationCode;
        private string locationMessage;
        private string progressCode;
        private string progressMessage;
        private string carrier;
        private string trackingNumber;
        private string logBucket;
        private string logKey;
        private int? errorCount;
        private string signature;
        private string signatureFileContents;
        private string currentManifest;
        private DateTime? creationDate;

        /// <summary>
        /// A unique identifier which refers to a particular job.
        ///  
        /// </summary>
        public string JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this.jobId != null;
        }

        /// <summary>
        /// Specifies whether the job to initiate is an import or export job.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Import, Export</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public JobType JobType
        {
            get { return this.jobType; }
            set { this.jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this.jobType != null;
        }

        /// <summary>
        /// Address you ship your storage device to.
        ///  
        /// </summary>
        public string AwsShippingAddress
        {
            get { return this.awsShippingAddress; }
            set { this.awsShippingAddress = value; }
        }

        // Check to see if AwsShippingAddress property is set
        internal bool IsSetAwsShippingAddress()
        {
            return this.awsShippingAddress != null;
        }

        /// <summary>
        /// A token representing the location of the storage device, such as "AtAWS".
        ///  
        /// </summary>
        public string LocationCode
        {
            get { return this.locationCode; }
            set { this.locationCode = value; }
        }

        // Check to see if LocationCode property is set
        internal bool IsSetLocationCode()
        {
            return this.locationCode != null;
        }

        /// <summary>
        /// A more human readable form of the physical location of the storage device.
        ///  
        /// </summary>
        public string LocationMessage
        {
            get { return this.locationMessage; }
            set { this.locationMessage = value; }
        }

        // Check to see if LocationMessage property is set
        internal bool IsSetLocationMessage()
        {
            return this.locationMessage != null;
        }

        /// <summary>
        /// A token representing the state of the job, such as "Started".
        ///  
        /// </summary>
        public string ProgressCode
        {
            get { return this.progressCode; }
            set { this.progressCode = value; }
        }

        // Check to see if ProgressCode property is set
        internal bool IsSetProgressCode()
        {
            return this.progressCode != null;
        }

        /// <summary>
        /// A more human readable form of the job status.
        ///  
        /// </summary>
        public string ProgressMessage
        {
            get { return this.progressMessage; }
            set { this.progressMessage = value; }
        }

        // Check to see if ProgressMessage property is set
        internal bool IsSetProgressMessage()
        {
            return this.progressMessage != null;
        }

        /// <summary>
        /// Name of the shipping company. This value is included when the LocationCode is "Returned".
        ///  
        /// </summary>
        public string Carrier
        {
            get { return this.carrier; }
            set { this.carrier = value; }
        }

        // Check to see if Carrier property is set
        internal bool IsSetCarrier()
        {
            return this.carrier != null;
        }

        /// <summary>
        /// The shipping tracking number assigned by AWS Import/Export to the storage device when it's returned to you. We return this value when the
        /// LocationCode is "Returned".
        ///  
        /// </summary>
        public string TrackingNumber
        {
            get { return this.trackingNumber; }
            set { this.trackingNumber = value; }
        }

        // Check to see if TrackingNumber property is set
        internal bool IsSetTrackingNumber()
        {
            return this.trackingNumber != null;
        }

        /// <summary>
        /// Amazon S3 bucket for user logs.
        ///  
        /// </summary>
        public string LogBucket
        {
            get { return this.logBucket; }
            set { this.logBucket = value; }
        }

        // Check to see if LogBucket property is set
        internal bool IsSetLogBucket()
        {
            return this.logBucket != null;
        }

        /// <summary>
        /// The key where the user logs were stored.
        ///  
        /// </summary>
        public string LogKey
        {
            get { return this.logKey; }
            set { this.logKey = value; }
        }

        // Check to see if LogKey property is set
        internal bool IsSetLogKey()
        {
            return this.logKey != null;
        }

        /// <summary>
        /// Number of errors. We return this value when the ProgressCode is Success or SuccessWithErrors.
        ///  
        /// </summary>
        public int ErrorCount
        {
            get { return this.errorCount ?? default(int); }
            set { this.errorCount = value; }
        }

        // Check to see if ErrorCount property is set
        internal bool IsSetErrorCount()
        {
            return this.errorCount.HasValue;
        }

        /// <summary>
        /// An encrypted code used to authenticate the request and response, for example, "DV+TpDfx1/TdSE9ktyK9k/bDTVI=". Only use this value is you
        /// want to create the signature file yourself. Generally you should use the SignatureFileContents value.
        ///  
        /// </summary>
        public string Signature
        {
            get { return this.signature; }
            set { this.signature = value; }
        }

        // Check to see if Signature property is set
        internal bool IsSetSignature()
        {
            return this.signature != null;
        }

        /// <summary>
        /// An encrypted code used to authenticate the request and response, for example, "DV+TpDfx1/TdSE9ktyK9k/bDTVI=". Only use this value is you
        /// want to create the signature file yourself. Generally you should use the SignatureFileContents value.
        ///  
        /// </summary>
        public string SignatureFileContents
        {
            get { return this.signatureFileContents; }
            set { this.signatureFileContents = value; }
        }

        // Check to see if SignatureFileContents property is set
        internal bool IsSetSignatureFileContents()
        {
            return this.signatureFileContents != null;
        }

        /// <summary>
        /// The last manifest submitted, which will be used to process the job.
        ///  
        /// </summary>
        public string CurrentManifest
        {
            get { return this.currentManifest; }
            set { this.currentManifest = value; }
        }

        // Check to see if CurrentManifest property is set
        internal bool IsSetCurrentManifest()
        {
            return this.currentManifest != null;
        }

        /// <summary>
        /// Timestamp of the CreateJob request in ISO8601 date format. For example "2010-03-28T20:27:35Z".
        ///  
        /// </summary>
        public DateTime CreationDate
        {
            get { return this.creationDate ?? default(DateTime); }
            set { this.creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this.creationDate.HasValue;
        }
    }
}
