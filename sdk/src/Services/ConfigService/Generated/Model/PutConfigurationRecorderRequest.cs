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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfigurationRecorder operation.
    /// Creates or updates the customer managed configuration recorder.
    /// 
    ///  
    /// <para>
    /// You can use this operation to create a new customer managed configuration recorder
    /// or to update the <c>roleARN</c> and the <c>recordingGroup</c> for an existing customer
    /// managed configuration recorder.
    /// </para>
    ///  
    /// <para>
    /// To start the customer managed configuration recorder and begin recording configuration
    /// changes for the resource types you specify, use the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_StartConfigurationRecorder.html">StartConfigurationRecorder</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/stop-start-recorder.html">
    /// <b>Working with the Configuration Recorder</b> </a> in the <i>Config Developer Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>One customer managed configuration recorder per account per Region</b> 
    /// </para>
    ///  
    /// <para>
    /// You can create only one customer managed configuration recorder for each account for
    /// each Amazon Web Services Region.
    /// </para>
    ///  
    /// <para>
    ///  <b>Default is to record all supported resource types, excluding the global IAM resource
    /// types</b> 
    /// </para>
    ///  
    /// <para>
    /// If you have not specified values for the <c>recordingGroup</c> field, the default
    /// for the customer managed configuration recorder is to record all supported resource
    /// types, excluding the global IAM resource types: <c>AWS::IAM::Group</c>, <c>AWS::IAM::Policy</c>,
    /// <c>AWS::IAM::Role</c>, and <c>AWS::IAM::User</c>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Tags are added at creation and cannot be updated</b> 
    /// </para>
    ///  
    /// <para>
    ///  <c>PutConfigurationRecorder</c> is an idempotent API. Subsequent requests won’t create
    /// a duplicate resource if one was already created. If a following request has different
    /// tags values, Config will ignore these differences and treat it as an idempotent request
    /// of the previous. In this case, tags will not be updated, even if they are different.
    /// </para>
    ///  
    /// <para>
    /// Use <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_TagResource.html">TagResource</a>
    /// and <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_UntagResource.html">UntagResource</a>
    /// to update tags after creation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutConfigurationRecorderRequest : AmazonConfigServiceRequest
    {
        private ConfigurationRecorder _configurationRecorder;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationRecorder. 
        /// <para>
        /// An object for the configuration recorder. A configuration recorder records configuration
        /// changes for the resource types in scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationRecorder ConfigurationRecorder
        {
            get { return this._configurationRecorder; }
            set { this._configurationRecorder = value; }
        }

        // Check to see if ConfigurationRecorder property is set
        internal bool IsSetConfigurationRecorder()
        {
            return this._configurationRecorder != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the customer managed configuration recorder. Each tag consists of a key
        /// and an optional value, both of which you define.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
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