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
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Amazon.Util.Internal
{
    /// <summary>
    /// This type is used to check if an out going request should not use the https_proxy or http_proxy environment variable if the
    /// host matches a pattern in the no_proxy environment variable.
    /// 
    /// The SDK does not do a full implementation of the no_proxy evaluation. It handles host name match with wildcard support. A full
    /// implementation would also support DNS IP resolution and CIDR pattern matching.
    /// </summary>
    public class NoProxyFilter
    {
        internal const string NO_PROXY_ENV_NAME = "no_proxy";

        public static readonly NoProxyFilter Instance = new NoProxyFilter(new EnvironmentVariableRetriever());

        private IList<Regex> _proxyFilterRegex = new List<Regex>();

        public NoProxyFilter(IEnvironmentVariableRetriever environmentVariableRetriever) 
        {
            var filters = environmentVariableRetriever.GetEnvironmentVariable(NO_PROXY_ENV_NAME)?.Split(',');
            if (filters == null)
            {
                return;
            }

            foreach (var filter in filters)
            {
                if (string.IsNullOrEmpty(filter))
                {
                    continue;
                }

                try
                {
                    var regExPattern = string.Concat(Regex.Escape(filter.Trim()).Replace("\\*", ".*"), "$");
                    var regEx = new Regex(regExPattern, RegexOptions.Compiled);
                    _proxyFilterRegex.Add(regEx);
                }
                catch(ArgumentException e)
                {
                    // We don't have any control if users have put invalid information in the no_proxy and the SDK's implementation is not a full
                    // implementation of no_proxy, we will skip any segements in the no_proxy env var that we fail to parse. Since no_proxy has existed
                    // before the SDK added this support we could introduce a breaking change if we start throwing fatal exceptions at this point.
                    Logger.GetLogger(typeof(NoProxyFilter)).Error(e, "Failed parse segment \"{0}\" in no_proxy environment variable.", filter);
                }
            }
        }

        /// <summary>
        /// Evaluates if the host in the Uri should be exluded from proxy if it matches a pattern in the no_proxy environment variable.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public bool Match(Uri uri)
        {
            var host = uri.Host;
            foreach(var filter in _proxyFilterRegex)
            {
                if(filter.IsMatch(host))
                {
                    return true;
                }
            }

            return false;
        }
    }
}