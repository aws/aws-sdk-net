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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTagsForResource operation.
    /// Update the list of tags applied to an AWS Elastic Beanstalk resource. Two lists can
    /// be passed: <c>TagsToAdd</c> for tags to add or update, and <c>TagsToRemove</c>.
    /// 
    ///  
    /// <para>
    /// Elastic Beanstalk supports tagging of all of its resources. For details about resource
    /// tagging, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/applications-tagging-resources.html">Tagging
    /// Application Resources</a>.
    /// </para>
    ///  
    /// <para>
    /// If you create a custom IAM user policy to control permission to this operation, specify
    /// one of the following two virtual actions (or both) instead of the API operation name:
    /// </para>
    ///  <dl> <dt>elasticbeanstalk:AddTags</dt> <dd> 
    /// <para>
    /// Controls permission to call <c>UpdateTagsForResource</c> and pass a list of tags to
    /// add in the <c>TagsToAdd</c> parameter.
    /// </para>
    ///  </dd> <dt>elasticbeanstalk:RemoveTags</dt> <dd> 
    /// <para>
    /// Controls permission to call <c>UpdateTagsForResource</c> and pass a list of tag keys
    /// to remove in the <c>TagsToRemove</c> parameter.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// For details about creating a custom user policy, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/AWSHowTo.iam.managed-policies.html#AWSHowTo.iam.policies">Creating
    /// a Custom User Policy</a>.
    /// </para>
    /// </summary>
    public partial class UpdateTagsForResourceRequest : AmazonElasticBeanstalkRequest
    {
        private string _resourceArn;
        private List<Tag> _tagsToAdd = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<string> _tagsToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resouce to be updated.
        /// </para>
        ///  
        /// <para>
        /// Must be the ARN of an Elastic Beanstalk resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of tags to add or update. If a key of an existing tag is added, the tag's value
        /// is updated.
        /// </para>
        ///  
        /// <para>
        /// Specify at least one of these parameters: <c>TagsToAdd</c>, <c>TagsToRemove</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagsToAdd
        {
            get { return this._tagsToAdd; }
            set { this._tagsToAdd = value; }
        }

        // Check to see if TagsToAdd property is set
        internal bool IsSetTagsToAdd()
        {
            return this._tagsToAdd != null && (this._tagsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagsToRemove. 
        /// <para>
        /// A list of tag keys to remove. If a tag key doesn't exist, it is silently ignored.
        /// </para>
        ///  
        /// <para>
        /// Specify at least one of these parameters: <c>TagsToAdd</c>, <c>TagsToRemove</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TagsToRemove
        {
            get { return this._tagsToRemove; }
            set { this._tagsToRemove = value; }
        }

        // Check to see if TagsToRemove property is set
        internal bool IsSetTagsToRemove()
        {
            return this._tagsToRemove != null && (this._tagsToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}