/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes tags from a Lambda function. Requires the function ARN (Amazon Resource Name).
    /// For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/tagging.html">Tagging
    /// Lambda Functions</a> in the <b>AWS Lambda Developer Guide</b>.
    /// </summary>
    public partial class UntagResourceRequest : AmazonLambdaRequest
    {
        private string _resource;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the function. For more information, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/tagging.html">Tagging
        /// Lambda Functions</a> in the <b>AWS Lambda Developer Guide</b>.
        /// </para>
        /// </summary>
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// The list of tag keys to be deleted from the function. For more information, see <a
        /// href="http://docs.aws.amazon.com/lambda/latest/dg/tagging.html">Tagging Lambda Functions</a>
        /// in the <b>AWS Lambda Developer Guide</b>.
        /// </para>
        /// </summary>
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && this._tagKeys.Count > 0; 
        }

    }
}