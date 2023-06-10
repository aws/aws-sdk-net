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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ImportStacksToStackSet operation.
    /// Import existing stacks into a new stack sets. Use the stack import operation to import
    /// up to 10 stacks into a new stack set in the same account as the source stack or in
    /// a different administrator account and Region, by specifying the stack ID of the stack
    /// you intend to import.
    /// </summary>
    public partial class ImportStacksToStackSetRequest : AmazonCloudFormationRequest
    {
        private CallAs _callAs;
        private string _operationId;
        private StackSetOperationPreferences _operationPreferences;
        private List<string> _organizationalUnitIds = new List<string>();
        private List<string> _stackIds = new List<string>();
        private string _stackIdsUrl;
        private string _stackSetName;

        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// By default, <code>SELF</code> is specified. Use <code>SELF</code> for stack sets with
        /// self-managed permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <code>SELF</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For service managed stack sets, specify <code>DELEGATED_ADMIN</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs
        {
            get { return this._callAs; }
            set { this._callAs = value; }
        }

        // Check to see if CallAs property is set
        internal bool IsSetCallAs()
        {
            return this._callAs != null;
        }

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// A unique, user defined, identifier for the stack set operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

        /// <summary>
        /// Gets and sets the property OperationPreferences. 
        /// <para>
        /// The user-specified preferences for how CloudFormation performs a stack set operation.
        /// </para>
        ///  
        /// <para>
        /// For more information about maximum concurrent accounts and failure tolerance, see
        /// <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-concepts.html#stackset-ops-options">Stack
        /// set operation options</a>.
        /// </para>
        /// </summary>
        public StackSetOperationPreferences OperationPreferences
        {
            get { return this._operationPreferences; }
            set { this._operationPreferences = value; }
        }

        // Check to see if OperationPreferences property is set
        internal bool IsSetOperationPreferences()
        {
            return this._operationPreferences != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitIds. 
        /// <para>
        /// The list of OU ID's to which the stacks being imported has to be mapped as deployment
        /// target.
        /// </para>
        /// </summary>
        public List<string> OrganizationalUnitIds
        {
            get { return this._organizationalUnitIds; }
            set { this._organizationalUnitIds = value; }
        }

        // Check to see if OrganizationalUnitIds property is set
        internal bool IsSetOrganizationalUnitIds()
        {
            return this._organizationalUnitIds != null && this._organizationalUnitIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackIds. 
        /// <para>
        /// The IDs of the stacks you are importing into a stack set. You import up to 10 stacks
        /// per stack set at a time.
        /// </para>
        ///  
        /// <para>
        /// Specify either <code>StackIds</code> or <code>StackIdsUrl</code>.
        /// </para>
        /// </summary>
        public List<string> StackIds
        {
            get { return this._stackIds; }
            set { this._stackIds = value; }
        }

        // Check to see if StackIds property is set
        internal bool IsSetStackIds()
        {
            return this._stackIds != null && this._stackIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackIdsUrl. 
        /// <para>
        /// The Amazon S3 URL which contains list of stack ids to be inputted.
        /// </para>
        ///  
        /// <para>
        /// Specify either <code>StackIds</code> or <code>StackIdsUrl</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5120)]
        public string StackIdsUrl
        {
            get { return this._stackIdsUrl; }
            set { this._stackIdsUrl = value; }
        }

        // Check to see if StackIdsUrl property is set
        internal bool IsSetStackIdsUrl()
        {
            return this._stackIdsUrl != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name of the stack set. The name must be unique in the Region where you create
        /// your stack set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

    }
}