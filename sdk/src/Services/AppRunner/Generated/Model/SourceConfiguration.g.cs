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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes the source deployed to an App Runner service. It can be a code or an image
    /// repository.
    /// </summary>
    public partial class SourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// Describes the resources that are needed to authenticate access to some source repositories.
        /// </para>
        /// </summary>
        public AuthenticationConfiguration AuthenticationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthenticationConfiguration() => this.AuthenticationConfiguration != null;

        /// <summary>
        /// Gets and sets the property AutoDeploymentsEnabled. 
        /// <para>
        /// If <c>true</c>, continuous integration from the source repository is enabled for the
        /// App Runner service. Each repository change (including any source code commit or new
        /// image version) starts a deployment.
        /// </para>
        ///  
        /// <para>
        /// Default: App Runner sets to <c>false</c> for a source image that uses an ECR Public
        /// repository or an ECR repository that's in an Amazon Web Services account other than
        /// the one that the service is in. App Runner sets to <c>true</c> in all other cases
        /// (which currently include a source code repository or a source image using a same-account
        /// ECR repository).
        /// </para>
        /// </summary>
        public bool? AutoDeploymentsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AutoDeploymentsEnabled property is set.
        /// </summary>
        internal bool IsSetAutoDeploymentsEnabled() => this.AutoDeploymentsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CodeRepository. 
        /// <para>
        /// The description of a source code repository.
        /// </para>
        ///  
        /// <para>
        /// You must provide either this member or <c>ImageRepository</c> (but not both).
        /// </para>
        /// </summary>
        public CodeRepository CodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the CodeRepository property is set.
        /// </summary>
        internal bool IsSetCodeRepository() => this.CodeRepository != null;

        /// <summary>
        /// Gets and sets the property ImageRepository. 
        /// <para>
        /// The description of a source image repository.
        /// </para>
        ///  
        /// <para>
        /// You must provide either this member or <c>CodeRepository</c> (but not both).
        /// </para>
        /// </summary>
        public ImageRepository ImageRepository { get; set; }

        /// <summary>
        /// Checks to see if the ImageRepository property is set.
        /// </summary>
        internal bool IsSetImageRepository() => this.ImageRepository != null;
    }
}
