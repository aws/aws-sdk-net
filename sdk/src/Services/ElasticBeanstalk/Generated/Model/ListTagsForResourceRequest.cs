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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Returns the tags applied to an AWS Elastic Beanstalk resource. The response contains
    /// a list of tag key-value pairs.
    /// 
    ///  
    /// <para>
    /// Currently, Elastic Beanstalk only supports tagging of Elastic Beanstalk environments.
    /// For details about environment tagging, see <a href="http://docs.aws.amazon.com/elasticbeanstalk/latest/dg/using-features.tagging.html">Tagging
    /// Resources in Your Elastic Beanstalk Environment</a>.
    /// </para>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonElasticBeanstalkRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resouce for which a tag list is requested.
        /// </para>
        ///  
        /// <para>
        /// Must be the ARN of an Elastic Beanstalk environment.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}