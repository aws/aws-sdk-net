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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the Cloud Map service discovery information for your virtual
    /// node.
    /// 
    ///  <note> 
    /// <para>
    /// Cloud Map is not available in the eu-south-1 Region.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AwsCloudMapServiceDiscovery
    {
        private List<AwsCloudMapInstanceAttribute> _attributes = AWSConfigs.InitializeCollections ? new List<AwsCloudMapInstanceAttribute>() : null;
        private IpPreference _ipPreference;
        private string _namespaceName;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A string map that contains attributes with values that you can use to filter instances
        /// by any custom attribute that you specified when you registered the instance. Only
        /// instances that match all of the specified key/value pairs will be returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsCloudMapInstanceAttribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpPreference. 
        /// <para>
        /// The preferred IP version that this virtual node uses. Setting the IP preference on
        /// the virtual node only overrides the IP preference set for the mesh on this specific
        /// node.
        /// </para>
        /// </summary>
        public IpPreference IpPreference
        {
            get { return this._ipPreference; }
            set { this._ipPreference = value; }
        }

        // Check to see if IpPreference property is set
        internal bool IsSetIpPreference()
        {
            return this._ipPreference != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the Cloud Map namespace to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Cloud Map service to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}