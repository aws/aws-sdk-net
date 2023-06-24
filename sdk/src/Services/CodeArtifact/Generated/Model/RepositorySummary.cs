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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Details about a repository, including its Amazon Resource Name (ARN), description,
    /// and domain information. The <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_ListRepositories.html">ListRepositories</a>
    /// operation returns a list of <code>RepositorySummary</code> objects.
    /// </summary>
    public partial class RepositorySummary
    {
        private string _administratorAccount;
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private string _domainName;
        private string _domainOwner;
        private string _name;

        /// <summary>
        /// Gets and sets the property AdministratorAccount. 
        /// <para>
        ///  The Amazon Web Services account ID that manages the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AdministratorAccount
        {
            get { return this._administratorAccount; }
            set { this._administratorAccount = value; }
        }

        // Check to see if AdministratorAccount property is set
        internal bool IsSetAdministratorAccount()
        {
            return this._administratorAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A timestamp that represents the date and time the repository was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  The name of the domain that contains the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain.
        /// It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DomainOwner
        {
            get { return this._domainOwner; }
            set { this._domainOwner = value; }
        }

        // Check to see if DomainOwner property is set
        internal bool IsSetDomainOwner()
        {
            return this._domainOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
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