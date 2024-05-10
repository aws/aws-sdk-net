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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
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
namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// This is the response object from the AssociateAttributeGroup operation.
    /// </summary>
    public partial class AssociateAttributeGroupResponse : AmazonWebServiceResponse
    {
        private string _applicationArn;
        private string _attributeGroupArn;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the application that was augmented with attributes.
        /// </para>
        /// </summary>
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeGroupArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the attribute group that contains the application's
        /// new attributes.
        /// </para>
        /// </summary>
        public string AttributeGroupArn
        {
            get { return this._attributeGroupArn; }
            set { this._attributeGroupArn = value; }
        }

        // Check to see if AttributeGroupArn property is set
        internal bool IsSetAttributeGroupArn()
        {
            return this._attributeGroupArn != null;
        }

    }
}