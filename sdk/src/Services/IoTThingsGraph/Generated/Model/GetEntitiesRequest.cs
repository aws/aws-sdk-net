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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the GetEntities operation.
    /// Gets definitions of the specified entities. Uses the latest version of the user's
    /// namespace by default. This API returns the following TDM entities.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Properties
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// States
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Events
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Actions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Capabilities
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Mappings
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Devices
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Device Models
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Services
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This action doesn't return definitions for systems, flows, and deployments.
    /// </para>
    /// </summary>
    public partial class GetEntitiesRequest : AmazonIoTThingsGraphRequest
    {
        private List<string> _ids = new List<string>();
        private long? _namespaceVersion;

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        /// An array of entity IDs.
        /// </para>
        ///  
        /// <para>
        /// The IDs should be in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>urn:tdm:REGION/ACCOUNT ID/default:device:DEVICENAME</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<string> Ids
        {
            get { return this._ids; }
            set { this._ids = value; }
        }

        // Check to see if Ids property is set
        internal bool IsSetIds()
        {
            return this._ids != null && this._ids.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NamespaceVersion. 
        /// <para>
        /// The version of the user's namespace. Defaults to the latest version of the user's
        /// namespace.
        /// </para>
        /// </summary>
        public long NamespaceVersion
        {
            get { return this._namespaceVersion.GetValueOrDefault(); }
            set { this._namespaceVersion = value; }
        }

        // Check to see if NamespaceVersion property is set
        internal bool IsSetNamespaceVersion()
        {
            return this._namespaceVersion.HasValue; 
        }

    }
}