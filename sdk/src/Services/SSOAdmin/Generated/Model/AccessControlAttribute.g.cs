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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// These are IAM Identity Center identity store attributes that you can configure for
    /// use in attributes-based access control (ABAC). You can create permissions policies
    /// that determine who can access your Amazon Web Services resources based upon the configured
    /// attribute values. When you enable ABAC and specify <c>AccessControlAttributes</c>,
    /// IAM Identity Center passes the attribute values of the authenticated user into IAM
    /// for use in policy evaluation.
    /// </summary>
    public partial class AccessControlAttribute
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the attribute associated with your identities in your identity source.
        /// This is used to map a specified attribute in your identity source with an attribute
        /// in IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value used for mapping a specified attribute to an identity source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessControlAttributeValue Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
