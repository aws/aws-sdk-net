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
    /// Container for the parameters to the UpdateTagsForResource operation.
    /// Update the list of tags applied to an AWS Elastic Beanstalk resource. Two lists can
    /// be passed: <code>TagsToAdd</code> for tags to add or update, and <code>TagsToRemove</code>.
    /// 
    ///  
    /// <para>
    /// Currently, Elastic Beanstalk only supports tagging of Elastic Beanstalk environments.
    /// </para>
    /// </summary>
    public partial class UpdateTagsForResourceRequest : AmazonElasticBeanstalkRequest
    {
        private string _resourceArn;
        private List<Tag> _tagsToAdd = new List<Tag>();
        private List<string> _tagsToRemove = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resouce to be updated.
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

        /// <summary>
        /// Gets and sets the property TagsToAdd. 
        /// <para>
        /// A list of tags to add or update.
        /// </para>
        ///  
        /// <para>
        /// If a key of an existing tag is added, the tag's value is updated.
        /// </para>
        /// </summary>
        public List<Tag> TagsToAdd
        {
            get { return this._tagsToAdd; }
            set { this._tagsToAdd = value; }
        }

        // Check to see if TagsToAdd property is set
        internal bool IsSetTagsToAdd()
        {
            return this._tagsToAdd != null && this._tagsToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagsToRemove. 
        /// <para>
        /// A list of tag keys to remove.
        /// </para>
        ///  
        /// <para>
        /// If a tag key doesn't exist, it is silently ignored.
        /// </para>
        /// </summary>
        public List<string> TagsToRemove
        {
            get { return this._tagsToRemove; }
            set { this._tagsToRemove = value; }
        }

        // Check to see if TagsToRemove property is set
        internal bool IsSetTagsToRemove()
        {
            return this._tagsToRemove != null && this._tagsToRemove.Count > 0; 
        }

    }
}