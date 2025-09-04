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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListImports operation.
    /// Lists all stacks that are importing an exported output value. To modify or remove
    /// an exported output value, first use this action to see which stacks are using it.
    /// To see the exported output values in your account, see <a>ListExports</a>.
    /// 
    ///  
    /// <para>
    /// For more information about importing an exported output value, see the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/TemplateReference/intrinsic-function-reference-importvalue.html">Fn::ImportValue</a>
    /// function.
    /// </para>
    /// </summary>
    public partial class ListImportsRequest : AmazonCloudFormationRequest
    {
        private string _exportName;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExportName. 
        /// <para>
        /// The name of the exported output value. CloudFormation returns the stack names that
        /// are importing this value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExportName
        {
            get { return this._exportName; }
            set { this._exportName = value; }
        }

        // Check to see if ExportName property is set
        internal bool IsSetExportName()
        {
            return this._exportName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string (provided by the <a>ListImports</a> response output) that identifies the
        /// next page of stacks that are importing the specified exported output value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}