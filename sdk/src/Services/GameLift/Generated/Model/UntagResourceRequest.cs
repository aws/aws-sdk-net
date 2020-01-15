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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes a tag that is assigned to a GameLift resource. Resource tags are used to organize
    /// AWS resources for a range of purposes. This action handles the permissions necessary
    /// to manage tags for the following GameLift resource types:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Build
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Script
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Fleet
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Alias
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GameSessionQueue
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MatchmakingConfiguration
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MatchmakingRuleSet
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To remove a tag from a resource, specify the unique ARN value for the resource and
    /// provide a string list containing one or more tags to be removed. This action succeeds
    /// even if the list includes tags that are not currently assigned to the specified resource.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// AWS Resources</a> in the <i>AWS General Reference</i> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
    /// AWS Tagging Strategies</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>TagResource</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UntagResourceRequest : AmazonGameLiftRequest
    {
        private string _resourceARN;
        private List<string> _tagKeys = new List<string>();

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        ///  The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to and uniquely identifies the GameLift resource that you want to
        /// remove tags from. GameLift resource ARNs are included in the data object for the resource,
        /// which can be retrieved by calling a List or Describe action for the resource type.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// A list of one or more tags to remove from the specified GameLift resource. Tags are
        /// developer-defined and structured as key-value pairs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
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