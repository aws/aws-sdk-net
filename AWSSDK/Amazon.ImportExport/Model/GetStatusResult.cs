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

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// <para> Output structure for the GetStatus operation. </para>
    /// </summary>
    public class GetStatusResult  
    {
        
        private string jobId;
        private string jobType;
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

        /// <summary>
        /// Sets the JobId property
        /// </summary>
        /// <param name="jobId">The value to set for the JobId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithJobId(string jobId)
        {
            this.jobId = jobId;
            return this;
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
        public string JobType
        {
            get { return this.jobType; }
            set { this.jobType = value; }
        }

        /// <summary>
        /// Sets the JobType property
        /// </summary>
        /// <param name="jobType">The value to set for the JobType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithJobType(string jobType)
        {
            this.jobType = jobType;
            return this;
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

        /// <summary>
        /// Sets the AwsShippingAddress property
        /// </summary>
        /// <param name="awsShippingAddress">The value to set for the AwsShippingAddress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithAwsShippingAddress(string awsShippingAddress)
        {
            this.awsShippingAddress = awsShippingAddress;
            return this;
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

        /// <summary>
        /// Sets the LocationCode property
        /// </summary>
        /// <param name="locationCode">The value to set for the LocationCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithLocationCode(string locationCode)
        {
            this.locationCode = locationCode;
            return this;
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

        /// <summary>
        /// Sets the LocationMessage property
        /// </summary>
        /// <param name="locationMessage">The value to set for the LocationMessage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithLocationMessage(string locationMessage)
        {
            this.locationMessage = locationMessage;
            return this;
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

        /// <summary>
        /// Sets the ProgressCode property
        /// </summary>
        /// <param name="progressCode">The value to set for the ProgressCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithProgressCode(string progressCode)
        {
            this.progressCode = progressCode;
            return this;
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

        /// <summary>
        /// Sets the ProgressMessage property
        /// </summary>
        /// <param name="progressMessage">The value to set for the ProgressMessage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithProgressMessage(string progressMessage)
        {
            this.progressMessage = progressMessage;
            return this;
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

        /// <summary>
        /// Sets the Carrier property
        /// </summary>
        /// <param name="carrier">The value to set for the Carrier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithCarrier(string carrier)
        {
            this.carrier = carrier;
            return this;
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

        /// <summary>
        /// Sets the TrackingNumber property
        /// </summary>
        /// <param name="trackingNumber">The value to set for the TrackingNumber property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithTrackingNumber(string trackingNumber)
        {
            this.trackingNumber = trackingNumber;
            return this;
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

        /// <summary>
        /// Sets the LogBucket property
        /// </summary>
        /// <param name="logBucket">The value to set for the LogBucket property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithLogBucket(string logBucket)
        {
            this.logBucket = logBucket;
            return this;
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

        /// <summary>
        /// Sets the LogKey property
        /// </summary>
        /// <param name="logKey">The value to set for the LogKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithLogKey(string logKey)
        {
            this.logKey = logKey;
            return this;
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

        /// <summary>
        /// Sets the ErrorCount property
        /// </summary>
        /// <param name="errorCount">The value to set for the ErrorCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithErrorCount(int errorCount)
        {
            this.errorCount = errorCount;
            return this;
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

        /// <summary>
        /// Sets the Signature property
        /// </summary>
        /// <param name="signature">The value to set for the Signature property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithSignature(string signature)
        {
            this.signature = signature;
            return this;
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

        /// <summary>
        /// Sets the SignatureFileContents property
        /// </summary>
        /// <param name="signatureFileContents">The value to set for the SignatureFileContents property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithSignatureFileContents(string signatureFileContents)
        {
            this.signatureFileContents = signatureFileContents;
            return this;
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

        /// <summary>
        /// Sets the CurrentManifest property
        /// </summary>
        /// <param name="currentManifest">The value to set for the CurrentManifest property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithCurrentManifest(string currentManifest)
        {
            this.currentManifest = currentManifest;
            return this;
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

        /// <summary>
        /// Sets the CreationDate property
        /// </summary>
        /// <param name="creationDate">The value to set for the CreationDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetStatusResult WithCreationDate(DateTime creationDate)
        {
            this.creationDate = creationDate;
            return this;
        }
            

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this.creationDate.HasValue;       
        }
    }
}
