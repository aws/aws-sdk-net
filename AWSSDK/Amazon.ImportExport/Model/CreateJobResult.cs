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
    /// <para> Output structure for the CreateJob operation. </para>
    /// </summary>
    public class CreateJobResult  
    {
        
        private string jobId;
        private string jobType;
        private string awsShippingAddress;
        private string signature;
        private string signatureFileContents;
        private string warningMessage;

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
        public CreateJobResult WithJobId(string jobId)
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
        public CreateJobResult WithJobType(string jobType)
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
        public CreateJobResult WithAwsShippingAddress(string awsShippingAddress)
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
        public CreateJobResult WithSignature(string signature)
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
        /// The actual text of the SIGNATURE file to be written to disk.
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
        public CreateJobResult WithSignatureFileContents(string signatureFileContents)
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
        /// An optional message notifying you of non-fatal issues with the job, such as use of an incompatible Amazon S3 bucket name.
        ///  
        /// </summary>
        public string WarningMessage
        {
            get { return this.warningMessage; }
            set { this.warningMessage = value; }
        }

        /// <summary>
        /// Sets the WarningMessage property
        /// </summary>
        /// <param name="warningMessage">The value to set for the WarningMessage property </param>
        /// <returns>this instance</returns>
        public CreateJobResult WithWarningMessage(string warningMessage)
        {
            this.warningMessage = warningMessage;
            return this;
        }
            

        // Check to see if WarningMessage property is set
        internal bool IsSetWarningMessage()
        {
            return this.warningMessage != null;       
        }
    }
}
