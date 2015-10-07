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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRulesPackage operation.
    /// Describes the rules package specified by the rules package ARN.
    /// </summary>
    public partial class DescribeRulesPackageRequest : AmazonInspectorRequest
    {
        private string _rulesPackageArn;

        /// <summary>
        /// Gets and sets the property RulesPackageArn. 
        /// <para>
        /// The ARN specifying the rules package that you want to describe.
        /// </para>
        /// </summary>
        public string RulesPackageArn
        {
            get { return this._rulesPackageArn; }
            set { this._rulesPackageArn = value; }
        }

        // Check to see if RulesPackageArn property is set
        internal bool IsSetRulesPackageArn()
        {
            return this._rulesPackageArn != null;
        }

    }
}