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

/*
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Container for the parameters to the CreateComplianceInquiry operation.
    /// Create a new compliance inquiry.
    /// </summary>
    public partial class CreateComplianceInquiryRequest : AmazonArtifactRequest
    {
        private string _clientToken;
        private InquiryContent _inquiryContent;
        private string _name;
        private InquirySupportMode _supportMode;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InquiryContent. 
        /// <para>
        /// Content for creating a compliance inquiry - either a single query or file content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public InquiryContent InquiryContent
        {
            get { return this._inquiryContent; }
            set { this._inquiryContent = value; }
        }

        // Check to see if InquiryContent property is set
        internal bool IsSetInquiryContent()
        {
            return this._inquiryContent != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Title of the inquiry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SupportMode. 
        /// <para>
        /// Support mode for inquiry processing. Only supported for file upload mode. Defaults
        /// to AI_ONLY if not specified.
        /// </para>
        /// </summary>
        public InquirySupportMode SupportMode
        {
            get { return this._supportMode; }
            set { this._supportMode = value; }
        }

        // Check to see if SupportMode property is set
        internal bool IsSetSupportMode()
        {
            return this._supportMode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the compliance inquiry resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}