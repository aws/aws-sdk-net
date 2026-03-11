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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
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
namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// The configuration settings for the application.
    /// </summary>
    public partial class ApplicationConfig
    {
        private ContactHandling _contactHandling;

        /// <summary>
        /// Gets and sets the property ContactHandling. 
        /// <para>
        /// The contact handling configuration for the application.
        /// </para>
        /// </summary>
        public ContactHandling ContactHandling
        {
            get { return this._contactHandling; }
            set { this._contactHandling = value; }
        }

        // Check to see if ContactHandling property is set
        internal bool IsSetContactHandling()
        {
            return this._contactHandling != null;
        }

    }
}