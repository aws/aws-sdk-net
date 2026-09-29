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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the package group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ContactInfo. 
        /// <para>
        ///  The contact information of the package group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string ContactInfo { get; set; }

        /// <summary>
        /// Checks to see if the ContactInfo property is set.
        /// </summary>
        internal bool IsSetContactInfo() => this.ContactInfo != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A timestamp that represents the date and time the package group was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the package group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  The name of the domain that contains the package group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain.
        /// It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DomainOwner { get; set; }

        /// <summary>
        /// Checks to see if the DomainOwner property is set.
        /// </summary>
        internal bool IsSetDomainOwner() => this.DomainOwner != null;

        /// <summary>
        /// Gets and sets the property OriginConfiguration. 
        /// <para>
        /// The package group origin configuration that determines how package versions can enter
        /// repositories.
        /// </para>
        /// </summary>
        public PackageGroupOriginConfiguration OriginConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OriginConfiguration property is set.
        /// </summary>
        internal bool IsSetOriginConfiguration() => this.OriginConfiguration != null;

        /// <summary>
        /// Gets and sets the property Parent. 
        /// <para>
        ///  The direct parent package group of the package group. 
        /// </para>
        /// </summary>
        public PackageGroupReference Parent { get; set; }

        /// <summary>
        /// Checks to see if the Parent property is set.
        /// </summary>
        internal bool IsSetParent() => this.Parent != null;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        ///  The pattern of the package group. The pattern determines which packages are associated
        /// with the package group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 520)]
        public string Pattern { get; set; }

        /// <summary>
        /// Checks to see if the Pattern property is set.
        /// </summary>
        internal bool IsSetPattern() => this.Pattern != null;
    }
}
