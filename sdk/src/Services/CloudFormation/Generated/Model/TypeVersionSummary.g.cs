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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Contains summary information about a specific version of a CloudFormation extension.
    /// </summary>
    public partial class TypeVersionSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the extension version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the extension version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsDefaultVersion. 
        /// <para>
        /// Whether the specified extension version is set as the default version.
        /// </para>
        ///  
        /// <para>
        /// This applies only to private extensions you have registered in your account, and extensions
        /// published by Amazon. For public third-party extensions, CloudFormation returns <c>null</c>.
        /// </para>
        /// </summary>
        public bool? IsDefaultVersion { get; set; }

        /// <summary>
        /// Checks to see if the IsDefaultVersion property is set.
        /// </summary>
        internal bool IsSetIsDefaultVersion() => this.IsDefaultVersion.HasValue;

        /// <summary>
        /// Gets and sets the property PublicVersionNumber. 
        /// <para>
        /// For public extensions that have been activated for this account and Region, the version
        /// of the public extension to be used for CloudFormation operations in this account and
        /// Region. For any extensions other than activated third-party extensions, CloudFormation
        /// returns <c>null</c>.
        /// </para>
        ///  
        /// <para>
        /// How you specified <c>AutoUpdate</c> when enabling the extension affects whether CloudFormation
        /// automatically updates the extension in this account and Region when a new version
        /// is released. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-public.html#registry-public-enable-auto">Automatically
        /// use new versions of extensions</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5)]
        public string PublicVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the PublicVersionNumber property is set.
        /// </summary>
        internal bool IsSetPublicVersionNumber() => this.PublicVersionNumber != null;

        /// <summary>
        /// Gets and sets the property TimeCreated. 
        /// <para>
        /// When the version was registered.
        /// </para>
        /// </summary>
        public DateTime? TimeCreated { get; set; }

        /// <summary>
        /// Checks to see if the TimeCreated property is set.
        /// </summary>
        internal bool IsSetTimeCreated() => this.TimeCreated.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of extension.
        /// </para>
        /// </summary>
        public RegistryType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 204)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of a specific version of the extension. The version ID is the value at the
        /// end of the ARN assigned to the extension version when it's registered.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
