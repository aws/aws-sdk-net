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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines a named input source, called a channel, to be used by an algorithm.
    /// </summary>
    public partial class ChannelSpecification
    {
        private string _description;
        private bool? _isRequired;
        private string _name;
        private List<string> _supportedCompressionTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedContentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _supportedInputModes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IsRequired. 
        /// <para>
        /// Indicates whether the channel is required by the algorithm.
        /// </para>
        /// </summary>
        public bool? IsRequired
        {
            get { return this._isRequired; }
            set { this._isRequired = value; }
        }

        // Check to see if IsRequired property is set
        internal bool IsSetIsRequired()
        {
            return this._isRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property SupportedCompressionTypes. 
        /// <para>
        /// The allowed compression types, if data compression is used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedCompressionTypes
        {
            get { return this._supportedCompressionTypes; }
            set { this._supportedCompressionTypes = value; }
        }

        // Check to see if SupportedCompressionTypes property is set
        internal bool IsSetSupportedCompressionTypes()
        {
            return this._supportedCompressionTypes != null && (this._supportedCompressionTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedContentTypes. 
        /// <para>
        /// The supported MIME types for the data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SupportedContentTypes
        {
            get { return this._supportedContentTypes; }
            set { this._supportedContentTypes = value; }
        }

        // Check to see if SupportedContentTypes property is set
        internal bool IsSetSupportedContentTypes()
        {
            return this._supportedContentTypes != null && (this._supportedContentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedInputModes. 
        /// <para>
        /// The allowed input mode, either FILE or PIPE.
        /// </para>
        ///  
        /// <para>
        /// In FILE mode, Amazon SageMaker copies the data from the input source onto the local
        /// Amazon Elastic Block Store (Amazon EBS) volumes before starting your training algorithm.
        /// This is the most commonly used input mode.
        /// </para>
        ///  
        /// <para>
        /// In PIPE mode, Amazon SageMaker streams input data from the source directly to your
        /// algorithm without using the EBS volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> SupportedInputModes
        {
            get { return this._supportedInputModes; }
            set { this._supportedInputModes = value; }
        }

        // Check to see if SupportedInputModes property is set
        internal bool IsSetSupportedInputModes()
        {
            return this._supportedInputModes != null && (this._supportedInputModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}