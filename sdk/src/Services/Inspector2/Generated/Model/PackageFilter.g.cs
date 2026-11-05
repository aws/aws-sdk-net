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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains information on the details of a package filter.
    /// </summary>
    public partial class PackageFilter
    {
        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// An object that contains details on the package architecture type to filter on.
        /// </para>
        /// </summary>
        public StringFilter Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property Epoch. 
        /// <para>
        /// An object that contains details on the package epoch to filter on.
        /// </para>
        /// </summary>
        public NumberFilter Epoch { get; set; }

        /// <summary>
        /// Checks to see if the Epoch property is set.
        /// </summary>
        internal bool IsSetEpoch() => this.Epoch != null;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// An object that contains details on the package file path to filter on.
        /// </para>
        /// </summary>
        public StringFilter FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An object that contains details on the name of the package to filter on.
        /// </para>
        /// </summary>
        public StringFilter Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Release. 
        /// <para>
        /// An object that contains details on the package release to filter on.
        /// </para>
        /// </summary>
        public StringFilter Release { get; set; }

        /// <summary>
        /// Checks to see if the Release property is set.
        /// </summary>
        internal bool IsSetRelease() => this.Release != null;

        /// <summary>
        /// Gets and sets the property SourceLambdaLayerArn. 
        /// <para>
        /// An object that describes the details of a string filter.
        /// </para>
        /// </summary>
        public StringFilter SourceLambdaLayerArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceLambdaLayerArn property is set.
        /// </summary>
        internal bool IsSetSourceLambdaLayerArn() => this.SourceLambdaLayerArn != null;

        /// <summary>
        /// Gets and sets the property SourceLayerHash. 
        /// <para>
        /// An object that contains details on the source layer hash to filter on.
        /// </para>
        /// </summary>
        public StringFilter SourceLayerHash { get; set; }

        /// <summary>
        /// Checks to see if the SourceLayerHash property is set.
        /// </summary>
        internal bool IsSetSourceLayerHash() => this.SourceLayerHash != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The package version to filter on.
        /// </para>
        /// </summary>
        public StringFilter Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
