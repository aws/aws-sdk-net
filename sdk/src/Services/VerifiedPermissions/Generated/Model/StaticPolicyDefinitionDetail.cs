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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// A structure that contains details about a static policy. It includes the description
    /// and policy body.
    /// 
    ///  
    /// <para>
    /// This data type is used within a <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_PolicyDefinition.html">PolicyDefinition</a>
    /// structure as part of a request parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_CreatePolicy.html">CreatePolicy</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class StaticPolicyDefinitionDetail
    {
        private string _description;
        private string _statement;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the static policy.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=150)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// The content of the static policy written in the Cedar policy language.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=10000)]
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

    }
}