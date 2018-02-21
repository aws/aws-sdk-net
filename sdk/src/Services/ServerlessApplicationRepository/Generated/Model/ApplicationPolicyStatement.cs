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
 * Do not modify this file. This file is generated from the serverlessrepo-2017-09-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// Policy statement applied to the application.
    /// </summary>
    public partial class ApplicationPolicyStatement
    {
        private List<string> _actions = new List<string>();
        private List<string> _principals = new List<string>();
        private string _statementId;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of supported actions:
        /// </para>
        /// 
        /// <para>
        ///  GetApplication 
        /// </para>
        /// 
        /// <para>
        ///  CreateCloudFormationChangeSet 
        /// </para>
        /// 
        /// <para>
        ///  ListApplicationVersions 
        /// </para>
        /// 
        /// <para>
        ///  SearchApplications 
        /// </para>
        /// 
        /// <para>
        ///  Deploy (Note: This action enables all other actions above.)
        /// </para>
        /// </summary>
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// An AWS account ID, or * to make the application public.
        /// </para>
        /// </summary>
        public List<string> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && this._principals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// A unique ID for the statement.
        /// </para>
        /// </summary>
        public string StatementId
        {
            get { return this._statementId; }
            set { this._statementId = value; }
        }

        // Check to see if StatementId property is set
        internal bool IsSetStatementId()
        {
            return this._statementId != null;
        }

    }
}