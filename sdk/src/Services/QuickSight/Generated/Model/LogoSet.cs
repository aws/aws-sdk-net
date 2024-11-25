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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A set of logos.
    /// </summary>
    public partial class LogoSet
    {
        private ImageSet _favicon;
        private ImageSet _primary;

        /// <summary>
        /// Gets and sets the property Favicon. 
        /// <para>
        /// The favicon logo.
        /// </para>
        /// </summary>
        public ImageSet Favicon
        {
            get { return this._favicon; }
            set { this._favicon = value; }
        }

        // Check to see if Favicon property is set
        internal bool IsSetFavicon()
        {
            return this._favicon != null;
        }

        /// <summary>
        /// Gets and sets the property Primary. 
        /// <para>
        /// The primary logo.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageSet Primary
        {
            get { return this._primary; }
            set { this._primary = value; }
        }

        // Check to see if Primary property is set
        internal bool IsSetPrimary()
        {
            return this._primary != null;
        }

    }
}