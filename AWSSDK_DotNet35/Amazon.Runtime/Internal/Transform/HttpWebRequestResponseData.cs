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
using System.Text;

namespace Amazon.Runtime.Internal.Transform
{
    internal class HttpWebRequestResponseData : IWebResponseData
    {
        HttpWebResponse _response;
        string[] _headerNames;
        HashSet<string> _headerNamesSet;

        public HttpWebRequestResponseData(HttpWebResponse response)
        {
            this._response = response;
        }

        public string ContentType
        {
            get { return this._response.ContentType; }
        }

        public Stream OpenResponse()
        {
            return this._response.GetResponseStream();
        }

        public HttpStatusCode StatusCode 
        {
            get { return this._response.StatusCode; }
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

        public string GetHeaderValue(string name)
        {
            return this._response.GetResponseHeader(name);
        }

        private void SetHeaderNames()
        {
            var keys = this._response.Headers.Keys;
            _headerNames = new string[keys.Count];
            for (int i = 0; i < keys.Count; i++)
                _headerNames[i] = keys[i];
            _headerNamesSet = new HashSet<string>(_headerNames, StringComparer.OrdinalIgnoreCase);
        }
    }
}
