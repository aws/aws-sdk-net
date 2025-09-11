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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSecurityConfiguration operation.
    /// Creates a security configuration. Security configurations in Amazon EMR on EKS are
    /// templates for different security setups. You can use security configurations to configure
    /// the Lake Formation integration setup. You can also create a security configuration
    /// to re-use a security setup each time you create a virtual cluster.
    /// </summary>
    public partial class CreateSecurityConfigurationRequest : AmazonEMRContainersRequest
    {
        private string _clientToken;
        private ContainerProvider _containerProvider;
        private string _name;
        private SecurityConfigurationData _securityConfigurationData;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client idempotency token to use when creating the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ContainerProvider. 
        /// <para>
        /// The container provider associated with the security configuration.
        /// </para>
        /// </summary>
        public ContainerProvider ContainerProvider
        {
            get { return this._containerProvider; }
            set { this._containerProvider = value; }
        }

        // Check to see if ContainerProvider property is set
        internal bool IsSetContainerProvider()
        {
            return this._containerProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the security configuration.
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
        /// Gets and sets the property SecurityConfigurationData. 
        /// <para>
        /// Security configuration input for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SecurityConfigurationData SecurityConfigurationData
        {
            get { return this._securityConfigurationData; }
            set { this._securityConfigurationData = value; }
        }

        // Check to see if SecurityConfigurationData property is set
        internal bool IsSetSecurityConfigurationData()
        {
            return this._securityConfigurationData != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the security configuration.
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