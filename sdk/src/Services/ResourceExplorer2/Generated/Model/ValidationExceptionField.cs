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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// A structure that describes a request field with a validation error.
    /// </summary>
    public partial class ValidationExceptionField
    {
        private string _name;
        private string _validationIssue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the request field that had a validation error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ValidationIssue. 
        /// <para>
        /// The validation error caused by the request field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ValidationIssue
        {
            get { return this._validationIssue; }
            set { this._validationIssue = value; }
        }

        // Check to see if ValidationIssue property is set
        internal bool IsSetValidationIssue()
        {
            return this._validationIssue != null;
        }

    }
}