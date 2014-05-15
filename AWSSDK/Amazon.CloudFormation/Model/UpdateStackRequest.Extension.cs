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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStack operation.
    /// <para>Updates a stack as specified in the template. After the call completes successfully, the stack update starts. You can check the status
    /// of the stack via the DescribeStacks action.</para> <para> <b>Note: </b> You cannot update <a
    /// href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html" >AWS::S3::Bucket</a> resources, for
    /// example, to add or modify tags.</para> <para>To get a copy of the template for an existing stack, you can use the GetTemplate
    /// action.</para> <para>Tags that were associated with this stack during creation time will still be associated with the stack after an
    /// <c>UpdateStack</c> operation.</para> <para>For more information about creating an update template, updating a stack, and monitoring the
    /// progress of the update, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-updating-stacks.html" >Updating
    /// a Stack</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFormation.AmazonCloudFormation.UpdateStack"/>
    public partial class UpdateStackRequest : AmazonWebServiceRequest
    {
        public UpdateStackRequest()
        {
            this.notificationARNs = new AutoConstructedList<string>();
        }
    }
}
    
