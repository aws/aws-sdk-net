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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// Five types of control parameters are supported.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>AllowedRegions</b>: List of Amazon Web Services Regions exempted from the control.
    /// Each string is expected to be an Amazon Web Services Region code. This parameter is
    /// mandatory for the <b>OU Region deny</b> control, <b>CT.MULTISERVICE.PV.1</b>.
    /// </para>
    ///  
    /// <para>
    /// Example: <c>["us-east-1","us-west-2"]</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ExemptedActions</b>: List of Amazon Web Services IAM actions exempted from the
    /// control. Each string is expected to be an IAM action.
    /// </para>
    ///  
    /// <para>
    /// Example: <c>["logs:DescribeLogGroups","logs:StartQuery","logs:GetQueryResults"]</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ExemptedPrincipalArns</b>: List of Amazon Web Services IAM principal ARNs exempted
    /// from the control. Each string is expected to be an IAM principal that follows the
    /// pattern <c>^arn:(aws|aws-us-gov):(iam|sts)::.+:.+$</c> 
    /// </para>
    ///  
    /// <para>
    /// Example: <c>["arn:aws:iam::*:role/ReadOnly","arn:aws:sts::*:assumed-role/ReadOnly/*"]</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ExemptedResourceArns</b>: List of resource ARNs exempted from the control. Each
    /// string is expected to be a resource ARN.
    /// </para>
    ///  
    /// <para>
    /// Example: <c>["arn:aws:s3:::my-bucket-name"]</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ExemptAssumeRoot</b>: A parameter that lets you choose whether to exempt requests
    /// made with <c>AssumeRoot</c> from this control, for this OU. For member accounts, the
    /// <c>AssumeRoot</c> property is included in requests initiated by IAM centralized root
    /// access. This parameter applies only to the <c>AWS-GR_RESTRICT_ROOT_USER</c> control.
    /// If you add the parameter when enabling the control, the <c>AssumeRoot</c> exemption
    /// is allowed. If you omit the parameter, the <c>AssumeRoot</c> exception is not permitted.
    /// The parameter does not accept <c>False</c> as a value.
    /// </para>
    ///  
    /// <para>
    ///  <i>Example: Enabling the control and allowing <c>AssumeRoot</c> </i> 
    /// </para>
    ///  
    /// <para>
    ///  <c>{ "controlIdentifier": "arn:aws:controlcatalog:::control/5kvme4m5d2b4d7if2fs5yg2ui",
    /// "parameters": [ { "key": "ExemptAssumeRoot", "value": true } ], "targetIdentifier":
    /// "arn:aws:organizations::8633900XXXXX:ou/o-6jmn81636m/ou-qsah-jtiihcla" }</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ControlParameter
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The parameter name. This name is the parameter <c>key</c> when you call <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_EnableControl.html">
        /// <c>EnableControl</c> </a> or <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/API_UpdateEnabledControl.html">
        /// <c>UpdateEnabledControl</c> </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}