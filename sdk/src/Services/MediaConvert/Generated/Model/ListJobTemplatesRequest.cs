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

/*
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobTemplates operation.
    /// Retrieve a JSON array of up to twenty of your job templates. This will return the
    /// templates themselves, not just a list of them. To retrieve the next twenty templates,
    /// use the nextToken string returned with the array
    /// </summary>
    public partial class ListJobTemplatesRequest : AmazonMediaConvertRequest
    {
        private string _category;
        private JobTemplateListBy _listBy;
        private int? _maxResults;
        private string _nextToken;
        private Order _order;

        /// <summary>
        /// Gets and sets the property Category. Optionally, specify a job template category to
        /// limit responses to only job templates from that category.
        /// </summary>
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property ListBy.
        /// </summary>
        public JobTemplateListBy ListBy
        {
            get { return this._listBy; }
            set { this._listBy = value; }
        }

        // Check to see if ListBy property is set
        internal bool IsSetListBy()
        {
            return this._listBy != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. Optional. Number of job templates, up to twenty,
        /// that will be returned at one time.
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. Use this string, provided with the response
        /// to a previous request, to request the next batch of job templates.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Order.
        /// </summary>
        public Order Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null;
        }

    }
}