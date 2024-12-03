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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// The Amazon QuickSight configuration for an Amazon Q Business application that uses
    /// QuickSight as the identity provider. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/create-quicksight-integrated-application.html">Creating
    /// an Amazon QuickSight integrated application</a>.
    /// </summary>
    public partial class QuickSightConfiguration
    {
        private string _clientNamespace;

        /// <summary>
        /// Gets and sets the property ClientNamespace. 
        /// <para>
        /// The Amazon QuickSight namespace that is used as the identity provider. For more information
        /// about QuickSight namespaces, see <a href="https://docs.aws.amazon.com/quicksight/latest/developerguide/namespace-operations.html">Namespace
        /// operations</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ClientNamespace
        {
            get { return this._clientNamespace; }
            set { this._clientNamespace = value; }
        }

        // Check to see if ClientNamespace property is set
        internal bool IsSetClientNamespace()
        {
            return this._clientNamespace != null;
        }

    }
}