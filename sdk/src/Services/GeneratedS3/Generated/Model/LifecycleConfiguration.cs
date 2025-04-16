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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for lifecycle rules. You can add as many as 1000 rules.
    /// 
    ///  
    /// <para>
    /// For more information see, <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lifecycle-mgmt.html">Managing
    /// your storage lifecycle</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class LifecycleConfiguration
    {
        private List<Rule> _rules = AWSConfigs.InitializeCollections ? new List<Rule>() : null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// Specifies lifecycle configuration rules for an Amazon S3 bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}