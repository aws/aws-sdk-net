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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Identifies the dependency using the <c>DependencyKeyAttributes</c> and <c>DependencyOperationName</c>.
    /// 
    ///  
    /// <para>
    /// When creating a service dependency SLO, you must specify the <c>KeyAttributes</c>
    /// of the service, and the <c>DependencyConfig</c> for the dependency. You can specify
    /// the <c>OperationName</c> of the service, from which it calls the dependency. Alternatively,
    /// you can exclude <c>OperationName</c> and the SLO will monitor all of the service's
    /// operations that call the dependency.
    /// </para>
    /// </summary>
    public partial class DependencyConfig
    {
        private Dictionary<string, string> _dependencyKeyAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _dependencyOperationName;

        /// <summary>
        /// Gets and sets the property DependencyKeyAttributes. 
        /// <para>
        /// This is a string-to-string map. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object this is.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> specifies the type of the resource. This field is used only when
        /// the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> specifies the name of the object. This is used only if the value of the
        /// <c>Type</c> field is <c>Service</c>, <c>RemoteService</c>, or <c>AWS::Service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Identifier</c> identifies the resource objects of this resource. This is used
        /// only if the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> specifies the location where this object is hosted, or what it
        /// belongs to.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public Dictionary<string, string> DependencyKeyAttributes
        {
            get { return this._dependencyKeyAttributes; }
            set { this._dependencyKeyAttributes = value; }
        }

        // Check to see if DependencyKeyAttributes property is set
        internal bool IsSetDependencyKeyAttributes()
        {
            return this._dependencyKeyAttributes != null && (this._dependencyKeyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DependencyOperationName. 
        /// <para>
        /// The name of the called operation in the dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DependencyOperationName
        {
            get { return this._dependencyOperationName; }
            set { this._dependencyOperationName = value; }
        }

        // Check to see if DependencyOperationName property is set
        internal bool IsSetDependencyOperationName()
        {
            return this._dependencyOperationName != null;
        }

    }
}