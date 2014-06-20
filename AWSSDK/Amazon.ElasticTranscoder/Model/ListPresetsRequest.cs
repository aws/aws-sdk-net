/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the ListPresets operation.
    /// The ListPresets operation gets a list of the default presets included with Elastic
    /// Transcoder and the            presets that you've added in an AWS region.
    /// </summary>
    public partial class ListPresetsRequest : AmazonWebServiceRequest
    {
        private string _ascending;
        private string _pageToken;


        /// <summary>
        /// Gets and sets the property Ascending. 
        /// <para>
        /// To list presets in chronological order by the date and time that they were created,
        /// enter            <code>true</code>. To list presets in reverse chronological order,
        /// enter            <code>false</code>.
        /// </para>
        /// </summary>
        public string Ascending
        {
            get { return this._ascending; }
            set { this._ascending = value; }
        }


        /// <summary>
        /// Sets the Ascending property
        /// </summary>
        /// <param name="ascending">The value to set for the Ascending property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListPresetsRequest WithAscending(string ascending)
        {
            this._ascending = ascending;
            return this;
        }

        // Check to see if Ascending property is set
        internal bool IsSetAscending()
        {
            return this._ascending != null;
        }


        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// When Elastic Transcoder returns more than one page of results, use <code>pageToken</code>
        /// in            subsequent <code>GET</code> requests to get each successive page of
        /// results. 
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }


        /// <summary>
        /// Sets the PageToken property
        /// </summary>
        /// <param name="pageToken">The value to set for the PageToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListPresetsRequest WithPageToken(string pageToken)
        {
            this._pageToken = pageToken;
            return this;
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

    }
}