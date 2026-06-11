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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFHIRDatastore operation.
    /// Update the properties of a FHIR-enabled data store.
    /// </summary>
    public partial class UpdateFHIRDatastoreRequest : AmazonHealthLakeRequest
    {
        private AnalyticsConfiguration _analyticsConfiguration;
        private string _datastoreId;
        private string _datastoreName;
        private IdentityProviderConfiguration _identityProviderConfiguration;
        private NlpConfiguration _nlpConfiguration;
        private ProfileConfiguration _profileConfiguration;

        /// <summary>
        /// Gets and sets the property AnalyticsConfiguration. <para>The analytics configuration
        /// for the data store.</para>
        /// </summary>
        public AnalyticsConfiguration AnalyticsConfiguration
        {
            get { return this._analyticsConfiguration; }
            set { this._analyticsConfiguration = value; }
        }

        // Check to see if AnalyticsConfiguration property is set
        internal bool IsSetAnalyticsConfiguration()
        {
            return this._analyticsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreId. <para>The data store identifier.</para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreName. <para>The data store name.</para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DatastoreName
        {
            get { return this._datastoreName; }
            set { this._datastoreName = value; }
        }

        // Check to see if DatastoreName property is set
        internal bool IsSetDatastoreName()
        {
            return this._datastoreName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderConfiguration. <para>The identity provider
        /// configuration for the data store.</para>
        /// </summary>
        public IdentityProviderConfiguration IdentityProviderConfiguration
        {
            get { return this._identityProviderConfiguration; }
            set { this._identityProviderConfiguration = value; }
        }

        // Check to see if IdentityProviderConfiguration property is set
        internal bool IsSetIdentityProviderConfiguration()
        {
            return this._identityProviderConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NlpConfiguration. <para>The NLP configuration for the data
        /// store.</para>
        /// </summary>
        public NlpConfiguration NlpConfiguration
        {
            get { return this._nlpConfiguration; }
            set { this._nlpConfiguration = value; }
        }

        // Check to see if NlpConfiguration property is set
        internal bool IsSetNlpConfiguration()
        {
            return this._nlpConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileConfiguration. <para>The profile configuration for
        /// the data store.</para>
        /// </summary>
        public ProfileConfiguration ProfileConfiguration
        {
            get { return this._profileConfiguration; }
            set { this._profileConfiguration = value; }
        }

        // Check to see if ProfileConfiguration property is set
        internal bool IsSetProfileConfiguration()
        {
            return this._profileConfiguration != null;
        }

    }
}