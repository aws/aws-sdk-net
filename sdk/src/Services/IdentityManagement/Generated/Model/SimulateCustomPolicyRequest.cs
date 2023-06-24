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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the SimulateCustomPolicy operation.
    /// Simulate how a set of IAM policies and optionally a resource-based policy works with
    /// a list of API operations and Amazon Web Services resources to determine the policies'
    /// effective permissions. The policies are provided as strings.
    /// 
    ///  
    /// <para>
    /// The simulation does not perform the API operations; it only checks the authorization
    /// to determine if the simulated policies allow or deny the operations. You can simulate
    /// resources that don't exist in your account.
    /// </para>
    ///  
    /// <para>
    /// If you want to simulate existing policies that are attached to an IAM user, group,
    /// or role, use <a>SimulatePrincipalPolicy</a> instead.
    /// </para>
    ///  
    /// <para>
    /// Context keys are variables that are maintained by Amazon Web Services and its services
    /// and which provide details about the context of an API query request. You can use the
    /// <code>Condition</code> element of an IAM policy to evaluate context keys. To get the
    /// list of context keys that the policies require for correct simulation, use <a>GetContextKeysForCustomPolicy</a>.
    /// </para>
    ///  
    /// <para>
    /// If the output is long, you can use <code>MaxItems</code> and <code>Marker</code> parameters
    /// to paginate the results.
    /// </para>
    ///  <note> 
    /// <para>
    /// The IAM policy simulator evaluates statements in the identity-based policy and the
    /// inputs that you provide during simulation. The policy simulator results can differ
    /// from your live Amazon Web Services environment. We recommend that you check your policies
    /// against your live Amazon Web Services environment after testing using the policy simulator
    /// to confirm that you have the desired results. For more information about using the
    /// policy simulator, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_testing-policies.html">Testing
    /// IAM policies with the IAM policy simulator </a>in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SimulateCustomPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private List<string> _actionNames = new List<string>();
        private string _callerArn;
        private List<ContextEntry> _contextEntries = new List<ContextEntry>();
        private string _marker;
        private int? _maxItems;
        private List<string> _permissionsBoundaryPolicyInputList = new List<string>();
        private List<string> _policyInputList = new List<string>();
        private List<string> _resourceArns = new List<string>();
        private string _resourceHandlingOption;
        private string _resourceOwner;
        private string _resourcePolicy;

        /// <summary>
        /// Gets and sets the property ActionNames. 
        /// <para>
        /// A list of names of API operations to evaluate in the simulation. Each operation is
        /// evaluated against each resource. Each operation must include the service identifier,
        /// such as <code>iam:CreateUser</code>. This operation does not support using wildcards
        /// (*) in an action name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ActionNames
        {
            get { return this._actionNames; }
            set { this._actionNames = value; }
        }

        // Check to see if ActionNames property is set
        internal bool IsSetActionNames()
        {
            return this._actionNames != null && this._actionNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CallerArn. 
        /// <para>
        /// The ARN of the IAM user that you want to use as the simulated caller of the API operations.
        /// <code>CallerArn</code> is required if you include a <code>ResourcePolicy</code> so
        /// that the policy's <code>Principal</code> element has a value to use in evaluating
        /// the policy.
        /// </para>
        ///  
        /// <para>
        /// You can specify only the ARN of an IAM user. You cannot specify the ARN of an assumed
        /// role, federated user, or a service principal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CallerArn
        {
            get { return this._callerArn; }
            set { this._callerArn = value; }
        }

        // Check to see if CallerArn property is set
        internal bool IsSetCallerArn()
        {
            return this._callerArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContextEntries. 
        /// <para>
        /// A list of context keys and corresponding values for the simulation to use. Whenever
        /// a context key is evaluated in one of the simulated IAM permissions policies, the corresponding
        /// value is supplied.
        /// </para>
        /// </summary>
        public List<ContextEntry> ContextEntries
        {
            get { return this._contextEntries; }
            set { this._contextEntries = value; }
        }

        // Check to see if ContextEntries property is set
        internal bool IsSetContextEntries()
        {
            return this._contextEntries != null && this._contextEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you receive a response
        /// indicating that the results are truncated. Set it to the value of the <code>Marker</code>
        /// element in the response that you received to indicate where the next call should start.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=320)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this only when paginating results to indicate the maximum number of items you
        /// want in the response. If additional items exist beyond the maximum you specify, the
        /// <code>IsTruncated</code> response element is <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// If you do not include this parameter, the number of items defaults to 100. Note that
        /// IAM might return fewer results, even when there are more results available. In that
        /// case, the <code>IsTruncated</code> response element returns <code>true</code>, and
        /// <code>Marker</code> contains a value to include in the subsequent call that tells
        /// the service where to continue from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PermissionsBoundaryPolicyInputList. 
        /// <para>
        /// The IAM permissions boundary policy to simulate. The permissions boundary sets the
        /// maximum permissions that an IAM entity can have. You can input only one permissions
        /// boundary when you pass a policy to this operation. For more information about permissions
        /// boundaries, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_boundaries.html">Permissions
        /// boundaries for IAM entities</a> in the <i>IAM User Guide</i>. The policy input is
        /// specified as a string that contains the complete, valid JSON text of a permissions
        /// boundary policy.
        /// </para>
        ///  
        /// <para>
        /// The maximum length of the policy document that you can pass in this operation, including
        /// whitespace, is listed below. To view the maximum character counts of a managed policy
        /// with no whitespaces, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html#reference_iam-quotas-entity-length">IAM
        /// and STS character quotas</a>.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<code>\u0020</code>)
        /// through the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <code>\u00FF</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>),
        /// and carriage return (<code>\u000D</code>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> PermissionsBoundaryPolicyInputList
        {
            get { return this._permissionsBoundaryPolicyInputList; }
            set { this._permissionsBoundaryPolicyInputList = value; }
        }

        // Check to see if PermissionsBoundaryPolicyInputList property is set
        internal bool IsSetPermissionsBoundaryPolicyInputList()
        {
            return this._permissionsBoundaryPolicyInputList != null && this._permissionsBoundaryPolicyInputList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyInputList. 
        /// <para>
        /// A list of policy documents to include in the simulation. Each document is specified
        /// as a string containing the complete, valid JSON text of an IAM policy. Do not include
        /// any resource-based policies in this parameter. Any resource-based policy must be submitted
        /// with the <code>ResourcePolicy</code> parameter. The policies cannot be "scope-down"
        /// policies, such as you could include in a call to <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetFederationToken.html">GetFederationToken</a>
        /// or one of the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AssumeRole.html">AssumeRole</a>
        /// API operations. In other words, do not use policies designed to restrict what a user
        /// can do while using the temporary credentials.
        /// </para>
        ///  
        /// <para>
        /// The maximum length of the policy document that you can pass in this operation, including
        /// whitespace, is listed below. To view the maximum character counts of a managed policy
        /// with no whitespaces, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html#reference_iam-quotas-entity-length">IAM
        /// and STS character quotas</a>.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<code>\u0020</code>)
        /// through the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <code>\u00FF</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>),
        /// and carriage return (<code>\u000D</code>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PolicyInputList
        {
            get { return this._policyInputList; }
            set { this._policyInputList = value; }
        }

        // Check to see if PolicyInputList property is set
        internal bool IsSetPolicyInputList()
        {
            return this._policyInputList != null && this._policyInputList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArns. 
        /// <para>
        /// A list of ARNs of Amazon Web Services resources to include in the simulation. If this
        /// parameter is not provided, then the value defaults to <code>*</code> (all resources).
        /// Each API in the <code>ActionNames</code> parameter is evaluated for each resource
        /// in this list. The simulation determines the access result (allowed or denied) of each
        /// combination and reports it in the response. You can simulate resources that don't
        /// exist in your account.
        /// </para>
        ///  
        /// <para>
        /// The simulation does not automatically retrieve policies for the specified resources.
        /// If you want to include a resource policy in the simulation, then you must include
        /// the policy as a string in the <code>ResourcePolicy</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you include a <code>ResourcePolicy</code>, then it must be applicable to all of
        /// the resources included in the simulation or you receive an invalid input error.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Simulation of resource-based policies isn't supported for IAM roles.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> ResourceArns
        {
            get { return this._resourceArns; }
            set { this._resourceArns = value; }
        }

        // Check to see if ResourceArns property is set
        internal bool IsSetResourceArns()
        {
            return this._resourceArns != null && this._resourceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceHandlingOption. 
        /// <para>
        /// Specifies the type of simulation to run. Different API operations that support resource-based
        /// policies require different combinations of resources. By specifying the type of simulation
        /// to run, you enable the policy simulator to enforce the presence of the required resources
        /// to ensure reliable simulation results. If your simulation does not match one of the
        /// following scenarios, then you can omit this parameter. The following list shows each
        /// of the supported scenario values and the resources that you must define to run the
        /// simulation.
        /// </para>
        ///  
        /// <para>
        /// Each of the EC2 scenarios requires that you specify instance, image, and security
        /// group resources. If your scenario includes an EBS volume, then you must specify that
        /// volume as a resource. If the EC2 scenario includes VPC, then you must supply the network
        /// interface resource. If it includes an IP subnet, then you must specify the subnet
        /// resource. For more information on the EC2 scenario options, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-supported-platforms.html">Supported
        /// platforms</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>EC2-VPC-InstanceStore</b> 
        /// </para>
        ///  
        /// <para>
        /// instance, image, security group, network interface
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EC2-VPC-InstanceStore-Subnet</b> 
        /// </para>
        ///  
        /// <para>
        /// instance, image, security group, network interface, subnet
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EC2-VPC-EBS</b> 
        /// </para>
        ///  
        /// <para>
        /// instance, image, security group, network interface, volume
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EC2-VPC-EBS-Subnet</b> 
        /// </para>
        ///  
        /// <para>
        /// instance, image, security group, network interface, subnet, volume
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ResourceHandlingOption
        {
            get { return this._resourceHandlingOption; }
            set { this._resourceHandlingOption = value; }
        }

        // Check to see if ResourceHandlingOption property is set
        internal bool IsSetResourceHandlingOption()
        {
            return this._resourceHandlingOption != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// An ARN representing the Amazon Web Services account ID that specifies the owner of
        /// any simulated resource that does not identify its owner in the resource ARN. Examples
        /// of resource ARNs include an S3 bucket or object. If <code>ResourceOwner</code> is
        /// specified, it is also used as the account owner of any <code>ResourcePolicy</code>
        /// included in the simulation. If the <code>ResourceOwner</code> parameter is not specified,
        /// then the owner of the resources and the resource policy defaults to the account of
        /// the identity provided in <code>CallerArn</code>. This parameter is required only if
        /// you specify a resource-based policy and account that owns the resource is different
        /// from the account that owns the simulated calling user <code>CallerArn</code>.
        /// </para>
        ///  
        /// <para>
        /// The ARN for an account uses the following syntax: <code>arn:aws:iam::<i>AWS-account-ID</i>:root</code>.
        /// For example, to represent the account with the 112233445566 ID, use the following
        /// ARN: <code>arn:aws:iam::112233445566-ID:root</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ResourceOwner
        {
            get { return this._resourceOwner; }
            set { this._resourceOwner = value; }
        }

        // Check to see if ResourceOwner property is set
        internal bool IsSetResourceOwner()
        {
            return this._resourceOwner != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        /// A resource-based policy to include in the simulation provided as a string. Each resource
        /// in the simulation is treated as if it had this policy attached. You can include only
        /// one resource-based policy in a simulation.
        /// </para>
        ///  
        /// <para>
        /// The maximum length of the policy document that you can pass in this operation, including
        /// whitespace, is listed below. To view the maximum character counts of a managed policy
        /// with no whitespaces, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html#reference_iam-quotas-entity-length">IAM
        /// and STS character quotas</a>.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<code>\u0020</code>)
        /// through the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <code>\u00FF</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>),
        /// and carriage return (<code>\u000D</code>)
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Simulation of resource-based policies isn't supported for IAM roles.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string ResourcePolicy
        {
            get { return this._resourcePolicy; }
            set { this._resourcePolicy = value; }
        }

        // Check to see if ResourcePolicy property is set
        internal bool IsSetResourcePolicy()
        {
            return this._resourcePolicy != null;
        }

    }
}