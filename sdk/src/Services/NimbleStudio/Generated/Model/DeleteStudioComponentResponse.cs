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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// <zonbook></zonbook><xhtml></xhtml>
    /// </summary>
    public partial class DeleteStudioComponentResponse : AmazonWebServiceResponse
    {
        private StudioComponent _studioComponent;

        /// <summary>
        /// Gets and sets the property StudioComponent. 
        /// <para>
        /// Information about the studio component.
        /// </para>
        /// </summary>
        public StudioComponent StudioComponent
        {
            get { return this._studioComponent; }
            set { this._studioComponent = value; }
        }

        // Check to see if StudioComponent property is set
        internal bool IsSetStudioComponent()
        {
            return this._studioComponent != null;
        }

    }
}