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
    /// Container for the parameters to the PutServiceLinkedConfigurationRecorder operation.
    /// Creates a service-linked configuration recorder that is linked to a specific Amazon
    /// Web Services service based on the <c>ServicePrincipal</c> you specify.
    /// 
    ///  
    /// <para>
    /// The configuration recorder's <c>name</c>, <c>recordingGroup</c>, <c>recordingMode</c>,
    /// and <c>recordingScope</c> is set by the service that is linked to the configuration
    /// recorder.
    /// </para>
    ///  
    /// <para>
    /// For more information and a list of supported services/service principals, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/stop-start-recorder.html">
    /// <b>Working with the Configuration Recorder</b> </a> in the <i>Config Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This API creates a service-linked role <c>AWSServiceRoleForConfig</c> in your account.
    /// The service-linked role is created only when the role does not exist in your account.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>The recording scope determines if you receive configuration items</b> 
    /// </para>
    ///  
    /// <para>
    /// The recording scope is set by the service that is linked to the configuration recorder
    /// and determines whether you receive configuration items (CIs) in the delivery channel.
    /// If the recording scope is internal, you will not receive CIs in the delivery channel.
    /// </para>
    ///  
    /// <para>
    ///  <b>Tags are added at creation and cannot be updated with this operation</b> 
    /// </para>
    ///  
    /// <para>
    /// Use <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_TagResource.html">TagResource</a>
    /// and <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_UntagResource.html">UntagResource</a>
    /// to update tags after creation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutServiceLinkedConfigurationRecorderRequest : AmazonConfigServiceRequest
    {
        private string _servicePrincipal;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// The service principal of the Amazon Web Services service for the service-linked configuration
        /// recorder that you want to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ServicePrincipal
        {
            get { return this._servicePrincipal; }
            set { this._servicePrincipal = value; }
        }

        // Check to see if ServicePrincipal property is set
        internal bool IsSetServicePrincipal()
        {
            return this._servicePrincipal != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for a service-linked configuration recorder. Each tag consists of a key and
        /// an optional value, both of which you define.
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