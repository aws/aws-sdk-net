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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Retrieves all tags assigned to a Amazon GameLift Servers resource. Use resource tags
    /// to organize Amazon Web Services resources for a range of purposes. This operation
    /// handles the permissions necessary to manage tags for Amazon GameLift Servers resources
    /// that support tagging.
    /// 
    ///  
    /// <para>
    /// To list tags for a resource, specify the unique ARN value for the resource.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
    /// Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <a href="http://aws.amazon.com/answers/account-management/aws-tagging-strategies/">
    /// Amazon Web Services Tagging Strategies</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonGameLiftRequest
    {
        private string _resourceARN;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that uniquely identifies the Amazon GameLift Servers resource that you want to retrieve
        /// tags for. Amazon GameLift Servers includes resource ARNs in the data object for the
        /// resource. You can retrieve the ARN by calling a <c>List</c> or <c>Describe</c> operation
        /// for the resource type. 
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

    }
}