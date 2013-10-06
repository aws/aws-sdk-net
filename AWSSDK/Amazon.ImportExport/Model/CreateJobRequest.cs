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
using Amazon.Runtime.Internal;

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// <para> This operation initiates the process of scheduling an upload or download of your data. You include in the request a manifest that
    /// describes the data transfer specifics. The response to the request includes a job ID, which you can use in other operations, a signature
    /// that you use to identify your storage device, and the address where you should ship your storage device. </para>
    /// </summary>
    /// <seealso cref="Amazon.ImportExport.AmazonImportExport.CreateJob"/>
    public class CreateJobRequest : AmazonWebServiceRequest
    {
        private string jobType;
        private string manifest;
        private string manifestAddendum;
        private bool? validateOnly;

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
        public CreateJobRequest WithJobType(string jobType)
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
        /// The UTF-8 encoded text of the manifest file.
        ///  
        /// </summary>
        public string Manifest
        {
            get { return this.manifest; }
            set { this.manifest = value; }
        }

        /// <summary>
        /// Sets the Manifest property
        /// </summary>
        /// <param name="manifest">The value to set for the Manifest property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithManifest(string manifest)
        {
            this.manifest = manifest;
            return this;
        }
            

        // Check to see if Manifest property is set
        internal bool IsSetManifest()
        {
            return this.manifest != null;       
        }

        /// <summary>
        /// For internal use only.
        ///  
        /// </summary>
        public string ManifestAddendum
        {
            get { return this.manifestAddendum; }
            set { this.manifestAddendum = value; }
        }

        /// <summary>
        /// Sets the ManifestAddendum property
        /// </summary>
        /// <param name="manifestAddendum">The value to set for the ManifestAddendum property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithManifestAddendum(string manifestAddendum)
        {
            this.manifestAddendum = manifestAddendum;
            return this;
        }
            

        // Check to see if ManifestAddendum property is set
        internal bool IsSetManifestAddendum()
        {
            return this.manifestAddendum != null;       
        }

        /// <summary>
        /// Validate the manifest and parameter values in the request but do not actually create a job.
        ///  
        /// </summary>
        public bool ValidateOnly
        {
            get { return this.validateOnly ?? default(bool); }
            set { this.validateOnly = value; }
        }

        /// <summary>
        /// Sets the ValidateOnly property
        /// </summary>
        /// <param name="validateOnly">The value to set for the ValidateOnly property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateJobRequest WithValidateOnly(bool validateOnly)
        {
            this.validateOnly = validateOnly;
            return this;
        }
            

        // Check to see if ValidateOnly property is set
        internal bool IsSetValidateOnly()
        {
            return this.validateOnly.HasValue;       
        }
    }
}
    
