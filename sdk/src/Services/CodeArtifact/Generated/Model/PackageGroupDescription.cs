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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// The description of the package group.
    /// </summary>
    public partial class PackageGroupDescription
    {
        private string _arn;
        private string _contactInfo;
        private DateTime? _createdTime;
        private string _description;
        private string _domainName;
        private string _domainOwner;
        private PackageGroupOriginConfiguration _originConfiguration;
        private PackageGroupReference _parent;
        private string _pattern;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the package group. 
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
        /// Gets and sets the property ContactInfo. 
        /// <para>
        ///  The contact information of the package group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ContactInfo
        {
            get { return this._contactInfo; }
            set { this._contactInfo = value; }
        }

        // Check to see if ContactInfo property is set
        internal bool IsSetContactInfo()
        {
            return this._contactInfo != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A timestamp that represents the date and time the package group was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
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
        ///  The description of the package group. 
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
        ///  The name of the domain that contains the package group. 
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
        /// Gets and sets the property OriginConfiguration. 
        /// <para>
        /// The package group origin configuration that determines how package versions can enter
        /// repositories.
        /// </para>
        /// </summary>
        public PackageGroupOriginConfiguration OriginConfiguration
        {
            get { return this._originConfiguration; }
            set { this._originConfiguration = value; }
        }

        // Check to see if OriginConfiguration property is set
        internal bool IsSetOriginConfiguration()
        {
            return this._originConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Parent. 
        /// <para>
        ///  The direct parent package group of the package group. 
        /// </para>
        /// </summary>
        public PackageGroupReference Parent
        {
            get { return this._parent; }
            set { this._parent = value; }
        }

        // Check to see if Parent property is set
        internal bool IsSetParent()
        {
            return this._parent != null;
        }

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        ///  The pattern of the package group. The pattern determines which packages are associated
        /// with the package group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=520)]
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

    }
}