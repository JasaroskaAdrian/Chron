# PROJECT_MANAGER.md

# Chron Development Workflow

This document defines how Chron is managed and how AI assistants should help with planning.

---

# Vision

Chron is a monster-catching RPG inspired by the feeling of exploration found in classic handheld RPGs while establishing its own identity.

The goal is **not** to clone Pokémon, but to build a unique world, creatures, mechanics and lore.

---

# Responsibilities

## Adrian

Responsible for:

- Game Design
- Programming
- World Design
- Final Decisions
- Code Review
- Art Direction

## AI Assistant

Responsible for:

- Breaking work into Issues
- Maintaining Roadmap
- Suggesting priorities
- Reviewing architecture
- Writing documentation
- Suggesting refactors
- Brainstorming mechanics
- Never changing Chron's vision without approval

---

# Workflow

Idea
↓

GitHub Issue
↓

Milestone
↓

Implementation
↓

Commit
↓

Close Issue
↓

Release

---

# GitHub Labels

- gameplay
- world
- art
- chron
- ui
- audio
- documentation
- bug
- enhancement
- refactor

---

# Priority

P0 - Critical
P1 - High
P2 - Medium
P3 - Low

---

# Issue Template

Title

Short, action-oriented title.

Description

Why this feature exists.

Tasks

- [ ] Task
- [ ] Task
- [ ] Task

Definition of Done

Describe what must be true before closing the issue.

---

# Milestones

v0.1.0 - First Playable

v0.2.0 - Expanded World

v0.3.0 - Battle Improvements

v0.4.0 - First Gym

v0.5.0 - First Region

v1.0.0 - Full Release

---

# Commit Messages

Use Conventional Commits.

Examples

feat(world): create Route 1

feat(chron): add Emberling

fix(player): resolve collision bug

refactor(battle): simplify damage calculation

docs(roadmap): update milestone

---

# AI Rules

When asked "What should I work on next?"

1. Prefer unfinished milestone issues.
2. Recommend the highest priority task.
3. Break large tasks into 1-3 hour chunks.
4. Avoid suggesting features outside the current milestone unless requested.
5. Keep Chron's scope focused.

---

# Definition of Done

An issue is complete only if:

- Implementation finished
- Tested
- No console errors
- Documentation updated (if needed)
- Commit created
- Issue closed

---

# Long-Term Goal

Build Chron incrementally through small, achievable milestones with consistent documentation and disciplined scope management.
