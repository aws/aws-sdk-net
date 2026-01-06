/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Concurrent;
using System.Threading;
using Amazon.Util;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Comprehensive logging system to track GetObjectResponse lifecycle and detect disposal leaks.
    /// This will provide concrete evidence of the disposal chain issues in OpenStreamWithResponseAsync.
    /// </summary>
    internal static class ResponseLeakLogger
    {
        private static volatile int _nextResponseId = 1;
        private static volatile int _totalCreated = 0;
        private static volatile int _totalDisposed = 0;
        private static readonly ConcurrentDictionary<int, ResponseInfo> _activeResponses = new();
        private static readonly Timer _leakReportTimer = new Timer(ReportLeakStatus, null, TimeSpan.FromSeconds(15), TimeSpan.FromSeconds(15));
        
        private class ResponseInfo
        {
            public int PartNumber { get; set; }
            public DateTime Created { get; set; }
            public string CreatedAt { get; set; }
            public string ProcessingPath { get; set; } // "STREAMING" or "BUFFERED"
            public bool DisposalAttempted { get; set; }
            public string LastLocation { get; set; }
        }
        
        /// <summary>
        /// Call this when a new GetObjectResponse is created for a part
        /// </summary>
        public static int TrackResponseCreated(int partNumber, string location)
        {
            int responseId = Interlocked.Increment(ref _nextResponseId);
            Interlocked.Increment(ref _totalCreated);
            
            var info = new ResponseInfo
            {
                PartNumber = partNumber,
                Created = AWSSDKUtils.CorrectedUtcNow,
                CreatedAt = location,
                ProcessingPath = "UNKNOWN"
            };
            
            _activeResponses[responseId] = info;
            
            Console.WriteLine($"[RESPONSE LEAK] CREATED ResponseId={responseId} Part={partNumber} at {location} | Active={_activeResponses.Count} Total=C:{_totalCreated}/D:{_totalDisposed}");
            
            return responseId;
        }
        
        /// <summary>
        /// Call this to mark which processing path the response takes
        /// </summary>
        public static void TrackProcessingPath(int responseId, string path)
        {
            if (_activeResponses.TryGetValue(responseId, out var info))
            {
                info.ProcessingPath = path;
                info.LastLocation = $"Routed to {path}";
                Console.WriteLine($"[RESPONSE LEAK] ROUTED ResponseId={responseId} Part={info.PartNumber} → {path}");
            }
        }
        
        /// <summary>
        /// Call this when attempting to dispose a response
        /// </summary>
        public static void TrackDisposalAttempt(int responseId, string location)
        {
            if (_activeResponses.TryGetValue(responseId, out var info))
            {
                info.DisposalAttempted = true;
                info.LastLocation = $"Disposal attempted at {location}";
                Console.WriteLine($"[RESPONSE LEAK] DISPOSAL_ATTEMPT ResponseId={responseId} Part={info.PartNumber} at {location}");
            }
        }
        
        /// <summary>
        /// Call this when a response is actually disposed
        /// </summary>
        public static void TrackResponseDisposed(int responseId, string location)
        {
            if (_activeResponses.TryRemove(responseId, out var info))
            {
                Interlocked.Increment(ref _totalDisposed);
                var lifetime = AWSSDKUtils.CorrectedUtcNow - info.Created;
                
                Console.WriteLine($"[RESPONSE LEAK] DISPOSED ResponseId={responseId} Part={info.PartNumber} at {location} | " +
                                 $"Lifetime={lifetime:mm\\:ss\\.fff} Path={info.ProcessingPath} | Active={_activeResponses.Count} Total=C:{_totalCreated}/D:{_totalDisposed}");
            }
            else
            {
                Console.WriteLine($"[RESPONSE LEAK] ERROR: Attempted to dispose unknown ResponseId={responseId} at {location}");
            }
        }
        
        /// <summary>
        /// Call this to track ownership transfer events
        /// </summary>
        public static void TrackOwnershipTransfer(int responseId, string from, string to)
        {
            if (_activeResponses.TryGetValue(responseId, out var info))
            {
                info.LastLocation = $"Ownership: {from} → {to}";
                Console.WriteLine($"[RESPONSE LEAK] OWNERSHIP ResponseId={responseId} Part={info.PartNumber} {from} → {to}");
            }
        }
        
        /// <summary>
        /// Track when exceptions occur during processing
        /// </summary>
        public static void TrackException(int responseId, string location, Exception ex)
        {
            if (_activeResponses.TryGetValue(responseId, out var info))
            {
                info.LastLocation = $"Exception at {location}: {ex.GetType().Name}";
                Console.WriteLine($"[RESPONSE LEAK] EXCEPTION ResponseId={responseId} Part={info.PartNumber} at {location}: {ex.GetType().Name} - {ex.Message}");
            }
        }
        
        /// <summary>
        /// Periodic report of potential leaks
        /// </summary>
        private static void ReportLeakStatus(object state)
        {
            var activeCount = _activeResponses.Count;
            var leakRate = (_totalCreated - _totalDisposed);
            
            Console.WriteLine($"[RESPONSE LEAK] STATUS: Active={activeCount} Created={_totalCreated} Disposed={_totalDisposed} LeakRate={leakRate}");
            
            if (activeCount > 10) // Threshold for concern
            {
                Console.WriteLine($"[RESPONSE LEAK] WARNING: {activeCount} active responses detected - potential leak!");
                
                // Show oldest active responses
                var now = AWSSDKUtils.CorrectedUtcNow;
                foreach (var kvp in _activeResponses)
                {
                    var age = now - kvp.Value.Created;
                    if (age > TimeSpan.FromMinutes(1)) // Responses older than 1 minute
                    {
                        var info = kvp.Value;
                        Console.WriteLine($"[RESPONSE LEAK] OLD: ResponseId={kvp.Key} Part={info.PartNumber} Age={age:mm\\:ss} " +
                                         $"Path={info.ProcessingPath} LastLocation={info.LastLocation} DisposalAttempted={info.DisposalAttempted}");
                    }
                }
            }
        }
        
        /// <summary>
        /// Force a detailed leak report
        /// </summary>
        public static void ForceLeakReport()
        {
            Console.WriteLine($"[RESPONSE LEAK] DETAILED REPORT: {_activeResponses.Count} active responses");
            
            foreach (var kvp in _activeResponses)
            {
                var info = kvp.Value;
                var age = AWSSDKUtils.CorrectedUtcNow - info.Created;
                Console.WriteLine($"[RESPONSE LEAK] ACTIVE: ResponseId={kvp.Key} Part={info.PartNumber} Age={age:mm\\:ss} " +
                                 $"Path={info.ProcessingPath} Created={info.CreatedAt} Last={info.LastLocation} " +
                                 $"DisposalAttempted={info.DisposalAttempted}");
            }
        }
    }
}
