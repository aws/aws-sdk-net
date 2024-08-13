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
    /// Configuration information about chat response personalization. For more information,
    /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/personalizing-chat-responses.html">Personalizing
    /// chat responses</a>.
    /// </summary>
    public partial class PersonalizationConfiguration
    {
        private PersonalizationControlMode _personalizationControlMode;

        /// <summary>
        /// Gets and sets the property PersonalizationControlMode. 
        /// <para>
        /// An option to allow Amazon Q Business to customize chat responses using user specific
        /// metadata—specifically, location and job information—in your IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PersonalizationControlMode PersonalizationControlMode
        {
            get { return this._personalizationControlMode; }
            set { this._personalizationControlMode = value; }
        }

        // Check to see if PersonalizationControlMode property is set
        internal bool IsSetPersonalizationControlMode()
        {
            return this._personalizationControlMode != null;
        }

    }
}