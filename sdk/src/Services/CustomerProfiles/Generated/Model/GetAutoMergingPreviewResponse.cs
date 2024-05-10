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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetAutoMergingPreview operation.
    /// </summary>
    public partial class GetAutoMergingPreviewResponse : AmazonWebServiceResponse
    {
        private string _domainName;
        private long? _numberOfMatchesInSample;
        private long? _numberOfProfilesInSample;
        private long? _numberOfProfilesWillBeMerged;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfMatchesInSample. 
        /// <para>
        /// The number of match groups in the domain that have been reviewed in this preview dry
        /// run.
        /// </para>
        /// </summary>
        public long? NumberOfMatchesInSample
        {
            get { return this._numberOfMatchesInSample; }
            set { this._numberOfMatchesInSample = value; }
        }

        // Check to see if NumberOfMatchesInSample property is set
        internal bool IsSetNumberOfMatchesInSample()
        {
            return this._numberOfMatchesInSample.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfProfilesInSample. 
        /// <para>
        /// The number of profiles found in this preview dry run.
        /// </para>
        /// </summary>
        public long? NumberOfProfilesInSample
        {
            get { return this._numberOfProfilesInSample; }
            set { this._numberOfProfilesInSample = value; }
        }

        // Check to see if NumberOfProfilesInSample property is set
        internal bool IsSetNumberOfProfilesInSample()
        {
            return this._numberOfProfilesInSample.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfProfilesWillBeMerged. 
        /// <para>
        /// The number of profiles that would be merged if this wasn't a preview dry run.
        /// </para>
        /// </summary>
        public long? NumberOfProfilesWillBeMerged
        {
            get { return this._numberOfProfilesWillBeMerged; }
            set { this._numberOfProfilesWillBeMerged = value; }
        }

        // Check to see if NumberOfProfilesWillBeMerged property is set
        internal bool IsSetNumberOfProfilesWillBeMerged()
        {
            return this._numberOfProfilesWillBeMerged.HasValue; 
        }

    }
}