//-----------------------------------------------------------------------
// <copyright file="AugmentedFaceMode.cs" company="Google">
//
// Copyright 2018 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace GoogleARCore
{
    /// <summary>
    /// Defines possible modes for AugmentedFace detection.
    /// </summary>
    public enum AugmentedFaceMode
    {
        /// <summary>
        /// A mode where AugmentedFace detection is disabled.
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// A mode where AugmentedFace detection performs face pose, region pose, and face mesh
        /// estimation.
        /// </summary>
        Mesh = 2
    }
}
