/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Transform
{
    public class HttpClientResponseData : IWebResponseData
    {
        HttpResponseMessage _response;
        string[] _headerNames;
        HashSet<string> _headerNamesSet;

        internal HttpClientResponseData(HttpResponseMessage response)
        {
            this._response = response;
        }

        public HttpStatusCode StatusCode
        {
            get { return this._response.StatusCode; }
        }

        public Stream OpenResponse()
        {
            var taskStream = this._response.Content.ReadAsStreamAsync();
            taskStream.Wait();
            return taskStream.Result;
        }

        public string ContentType
        {
            get
            {
                return GetHeaderValue("Content-Type");
            }
        }

        public string GetHeaderValue(string headerName)
        {
            IEnumerable<string> headerValues;

            if(this._response.Content != null && this._response.Content.Headers.TryGetValues(headerName, out headerValues))
                return headerValues.FirstOrDefault();
            if(this._response.Headers.TryGetValues(headerName, out headerValues))
                return headerValues.FirstOrDefault();

            return null;
        }

        public bool IsHeaderPresent(string headerName)
        {
            if (_headerNamesSet == null)
                SetHeaderNames();
            return _headerNamesSet.Contains(headerName);
        }

        public string[] GetHeaderNames()
        {
            if (_headerNames == null)
            {
                SetHeaderNames();
            }
            return _headerNames;
        }

        private void SetHeaderNames()
        {
            List<string> headerNames = new List<string>();
            foreach (KeyValuePair<string,IEnumerable<string>> kvp in this._response.Headers)
            {
                headerNames.Add(kvp.Key);
            }
            if (this._response.Content != null)
            {
                foreach (var kvp in this._response.Content.Headers)
                {
                    if(!headerNames.Contains(kvp.Key))
                        headerNames.Add(kvp.Key);
                }
            }
            _headerNames = headerNames.ToArray();
            _headerNamesSet = new HashSet<string>(_headerNames, StringComparer.OrdinalIgnoreCase);
        }
    }
}
