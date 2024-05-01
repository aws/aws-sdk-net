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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for users or groups in your IAM Identity Center
    /// identity source for access to your Amazon Kendra experience. Specific permissions
    /// are defined for each user or group once they are granted access to your Amazon Kendra
    /// experience.
    /// </summary>
    public partial class EntityPersonaConfiguration
    {
        private string _entityId;
        private Persona _persona;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of a user or group in your IAM Identity Center identity source. For
        /// example, a user ID could be an email.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=47)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property Persona. 
        /// <para>
        /// The persona that defines the specific permissions of the user or group in your IAM
        /// Identity Center identity source. The available personas or access roles are <c>Owner</c>
        /// and <c>Viewer</c>. For more information on these personas, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html#access-search-experience">Providing
        /// access to your search page</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Persona Persona
        {
            get { return this._persona; }
            set { this._persona = value; }
        }

        // Check to see if Persona property is set
        internal bool IsSetPersona()
        {
            return this._persona != null;
        }

    }
}