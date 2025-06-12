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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteStack operation.
    /// Deletes a specified stack. Once the call completes successfully, stack deletion starts.
    /// Deleted stacks don't show up in the <a>DescribeStacks</a> operation if the deletion
    /// has been completed successfully.
    /// 
    ///  
    /// <para>
    /// For more information about deleting a stack, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/cfn-console-delete-stack.html">Delete
    /// a stack from the CloudFormation console</a> in the <i>CloudFormation User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeleteStackRequest : AmazonCloudFormationRequest
    {
        private string _clientRequestToken;
        private DeletionMode _deletionMode;
        private List<string> _retainResources = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleARN;
        private string _stackName;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for this <c>DeleteStack</c> request. Specify this token if you
        /// plan to retry requests so that CloudFormation knows that you're not attempting to
        /// delete a stack with the same name. You might retry <c>DeleteStack</c> requests to
        /// ensure that CloudFormation successfully received them.
        /// </para>
        ///  
        /// <para>
        /// All events initiated by a given stack operation are assigned the same client request
        /// token, which you can use to track operations. For example, if you execute a <c>CreateStack</c>
        /// operation with the token <c>token1</c>, then all the <c>StackEvents</c> generated
        /// by that operation will have <c>ClientRequestToken</c> set as <c>token1</c>.
        /// </para>
        ///  
        /// <para>
        /// In the console, stack operations display the client request token on the Events tab.
        /// Stack operations that are initiated from the console use the token format <i>Console-StackOperation-ID</i>,
        /// which helps you easily identify the stack operation . For example, if you create a
        /// stack using the console, each stack event would be assigned the same token in the
        /// following format: <c>Console-CreateStack-7f59c3cf-00d2-40c7-b2ff-e75db0987002</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionMode. 
        /// <para>
        /// Specifies the deletion mode for the stack. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STANDARD</c> - Use the standard behavior. Specifying this value is the same as
        /// not specifying this parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORCE_DELETE_STACK</c> - Delete the stack if it's stuck in a <c>DELETE_FAILED</c>
        /// state due to resource deletion failure.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeletionMode DeletionMode
        {
            get { return this._deletionMode; }
            set { this._deletionMode = value; }
        }

        // Check to see if DeletionMode property is set
        internal bool IsSetDeletionMode()
        {
            return this._deletionMode != null;
        }

        /// <summary>
        /// Gets and sets the property RetainResources. 
        /// <para>
        /// For stacks in the <c>DELETE_FAILED</c> state, a list of resource logical IDs that
        /// are associated with the resources you want to retain. During deletion, CloudFormation
        /// deletes the stack but doesn't delete the retained resources.
        /// </para>
        ///  
        /// <para>
        /// Retaining resources is useful when you can't delete a resource, such as a non-empty
        /// S3 bucket, but you want to delete the stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RetainResources
        {
            get { return this._retainResources; }
            set { this._retainResources = value; }
        }

        // Check to see if RetainResources property is set
        internal bool IsSetRetainResources()
        {
            return this._retainResources != null && (this._retainResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that CloudFormation assumes to delete
        /// the stack. CloudFormation uses the role's credentials to make calls on your behalf.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, CloudFormation uses the role that was previously associated
        /// with the stack. If no role is available, CloudFormation uses a temporary session that's
        /// generated from your user credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The name or the unique stack ID that's associated with the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

    }
}