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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that lets you specify the namespaces that you want to list services
    /// for.
    /// </summary>
    public partial class ServiceFilter
    {
        private FilterCondition _condition;
        private ServiceFilterName _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The operator that you want to use to determine whether a service is returned by <c>ListServices</c>.
        /// Valid values for <c>Condition</c> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EQ</c>: When you specify <c>EQ</c>, specify one value. <c>EQ</c> is the default
        /// condition and can be omitted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FilterCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specify the services that you want to get using one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NAMESPACE_ID</c>: Gets the services associated with the specified namespace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE_OWNER</c>: Gets the services associated with the namespaces created by
        /// your Amazon Web Services account or by other accounts. This can be used to filter
        /// for services created in a shared namespace. For more information about shared namespaces,
        /// see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/sharing-namespaces.html">Cross-account
        /// Cloud Map namespace sharing</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceFilterName Name
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
        /// Gets and sets the property Values. 
        /// <para>
        /// The values that are applicable to the value that you specify for <c>Condition</c>
        /// to filter the list of services.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>NAMESPACE_ID</b>: Specify one namespace ID or ARN. Specify the namespace ARN for
        /// namespaces that are shared with your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RESOURCE_OWNER</b>: Specify one of <c>SELF</c> or <c>OTHER_ACCOUNTS</c>. <c>SELF</c>
        /// can be used to filter services associated with namespaces created by you and <c>OTHER_ACCOUNTS</c>
        /// can be used to filter services associated with namespaces that were shared with you.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}