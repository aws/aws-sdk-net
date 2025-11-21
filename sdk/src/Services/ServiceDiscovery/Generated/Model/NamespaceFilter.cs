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
    /// A complex type that identifies the namespaces that you want to list. You can choose
    /// to list public or private namespaces.
    /// </summary>
    public partial class NamespaceFilter
    {
        private FilterCondition _condition;
        private NamespaceFilterName _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// Specify the operator that you want to use to determine whether a namespace matches
        /// the specified value. Valid values for <c>Condition</c> are one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EQ</c>: When you specify <c>EQ</c> for <c>Condition</c>, you can specify only
        /// one value. <c>EQ</c> is supported for <c>TYPE</c>, <c>NAME</c>, <c>RESOURCE_OWNER</c>
        /// and <c>HTTP_NAME</c>. <c>EQ</c> is the default condition and can be omitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BEGINS_WITH</c>: When you specify <c>BEGINS_WITH</c> for <c>Condition</c>, you
        /// can specify only one value. <c>BEGINS_WITH</c> is supported for <c>TYPE</c>, <c>NAME</c>,
        /// and <c>HTTP_NAME</c>.
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
        /// Specify the namespaces that you want to get using one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TYPE</c>: Gets the namespaces of the specified type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NAME</c>: Gets the namespaces with the specified name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTP_NAME</c>: Gets the namespaces with the specified HTTP name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE_OWNER</c>: Gets the namespaces created by your Amazon Web Services account
        /// or by other accounts. This can be used to filter for shared namespaces. For more information
        /// about shared namespaces, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/sharing-namespaces.html">Cross-account
        /// Cloud Map namespace sharing</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public NamespaceFilterName Name
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
        /// Specify the values that are applicable to the value that you specify for <c>Name</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TYPE</c>: Specify <c>HTTP</c>, <c>DNS_PUBLIC</c>, or <c>DNS_PRIVATE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NAME</c>: Specify the name of the namespace, which is found in <c>Namespace.Name</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTP_NAME</c>: Specify the HTTP name of the namespace, which is found in <c>Namespace.Properties.HttpProperties.HttpName</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE_OWNER</c>: Specify one of <c>SELF</c> or <c>OTHER_ACCOUNTS</c>. <c>SELF</c>
        /// can be used to filter namespaces created by you and <c>OTHER_ACCOUNTS</c> can be used
        /// to filter namespaces shared with you that were created by other accounts.
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