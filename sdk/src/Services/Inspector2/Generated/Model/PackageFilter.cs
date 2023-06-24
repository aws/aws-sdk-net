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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains information on the details of a package filter.
    /// </summary>
    public partial class PackageFilter
    {
        private StringFilter _architecture;
        private NumberFilter _epoch;
        private StringFilter _name;
        private StringFilter _release;
        private StringFilter _sourceLambdaLayerArn;
        private StringFilter _sourceLayerHash;
        private StringFilter _version;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// An object that contains details on the package architecture type to filter on.
        /// </para>
        /// </summary>
        public StringFilter Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property Epoch. 
        /// <para>
        /// An object that contains details on the package epoch to filter on.
        /// </para>
        /// </summary>
        public NumberFilter Epoch
        {
            get { return this._epoch; }
            set { this._epoch = value; }
        }

        // Check to see if Epoch property is set
        internal bool IsSetEpoch()
        {
            return this._epoch != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An object that contains details on the name of the package to filter on.
        /// </para>
        /// </summary>
        public StringFilter Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Release. 
        /// <para>
        /// An object that contains details on the package release to filter on.
        /// </para>
        /// </summary>
        public StringFilter Release
        {
            get { return this._release; }
            set { this._release = value; }
        }

        // Check to see if Release property is set
        internal bool IsSetRelease()
        {
            return this._release != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLambdaLayerArn.
        /// </summary>
        public StringFilter SourceLambdaLayerArn
        {
            get { return this._sourceLambdaLayerArn; }
            set { this._sourceLambdaLayerArn = value; }
        }

        // Check to see if SourceLambdaLayerArn property is set
        internal bool IsSetSourceLambdaLayerArn()
        {
            return this._sourceLambdaLayerArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLayerHash. 
        /// <para>
        /// An object that contains details on the source layer hash to filter on.
        /// </para>
        /// </summary>
        public StringFilter SourceLayerHash
        {
            get { return this._sourceLayerHash; }
            set { this._sourceLayerHash = value; }
        }

        // Check to see if SourceLayerHash property is set
        internal bool IsSetSourceLayerHash()
        {
            return this._sourceLayerHash != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The package version to filter on.
        /// </para>
        /// </summary>
        public StringFilter Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}