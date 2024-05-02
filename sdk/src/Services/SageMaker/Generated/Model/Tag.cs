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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A tag object that consists of a key and an optional value, used to manage metadata
    /// for SageMaker Amazon Web Services resources.
    /// 
    ///  
    /// <para>
    /// You can add tags to notebook instances, training jobs, hyperparameter tuning jobs,
    /// batch transform jobs, models, labeling jobs, work teams, endpoint configurations,
    /// and endpoints. For more information on adding tags to SageMaker resources, see <a
    /// href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AddTags.html">AddTags</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information on adding metadata to your Amazon Web Services resources with
    /// tagging, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// Amazon Web Services resources</a>. For advice on best practices for managing Amazon
    /// Web Services resources with tagging, see <a href="https://d1.awsstatic.com/whitepapers/aws-tagging-best-practices.pdf">Tagging
    /// Best Practices: Implement an Effective Amazon Web Services Resource Tagging Strategy</a>.
    /// </para>
    /// </summary>
    public partial class Tag
    {
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The tag key. Tag keys must be unique per resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The tag value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}